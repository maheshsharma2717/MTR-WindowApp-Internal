using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.CustomControls;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MTRDesktopApplication
{
    public partial class EditBooking : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        public int _bookingID = 0;
        public event EventHandler SaveComplete;
        public List<Destination> destinations = new List<Destination>();
        private Dictionary<string, double> busStopCostDictionary = new Dictionary<string, double>();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        public EditBooking()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.AutoScroll = true;
            SetRoundButton(Savebutton);
            SetRoundButton(seatChangeBtn);
            SetRoundPanel(panel2, 7, Color.LightGray);
            SetRoundPanel(panel3, 7, Color.LightGray);
            SetRoundPanel(panel5, 7, Color.LightGray);
            SetRoundPanel(panel6, 7, Color.LightGray);
            SetRoundPanel(panel7, 7, Color.LightGray);
            SetRoundPanel(panel4, 7, Color.LightGray);
            SetRoundPanel(panel8, 7, Color.LightGray);
            SetRoundPanel(panel9, 7, Color.LightGray);
            SetRoundPanel(panel11, 7, Color.LightGray);
            SetRoundPanel(panel12, 7, Color.LightGray);
            SetRoundPanel(panel10, 7, Color.LightGray);
            SetRoundPanel(panel13, 7, Color.LightGray);
            SetRoundPanel(panel14, 7, Color.LightGray);
            SetRoundPanel(panel18, 7, Color.LightGray);
            SetRoundPanel(panel19, 7, Color.LightGray);
            SetRoundPanel(panel20, 7, Color.LightGray);
        }
        private void SetRoundButton(Button button)
        {
            int radius = 10;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = button.ClientRectangle;
            bounds.Inflate(-1, -1);
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }
        private void SetRoundPanel(Panel panel, int radius, Color borderColor)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(borderColor, 1))
                {
                    Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                    DrawRoundedRectangle(g, pen, rect, radius);
                }
            };
        }
        private void DrawRoundedRectangle(Graphics g, Pen pen, Rectangle bounds, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            g.DrawArc(pen, arc, 180, 90);
            arc.X = bounds.Right - diameter;
            g.DrawArc(pen, arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            g.DrawArc(pen, arc, 0, 90);
            arc.X = bounds.Left;
            g.DrawArc(pen, arc, 90, 90);
            g.DrawLine(pen, bounds.Left + cornerRadius, bounds.Top, bounds.Right - cornerRadius, bounds.Top);
            g.DrawLine(pen, bounds.Right, bounds.Top + cornerRadius, bounds.Right, bounds.Bottom - cornerRadius);
            g.DrawLine(pen, bounds.Left + cornerRadius, bounds.Bottom, bounds.Right - cornerRadius, bounds.Bottom);
            g.DrawLine(pen, bounds.Left, bounds.Top + cornerRadius, bounds.Left, bounds.Bottom - cornerRadius);
        }
        private async Task PopulateBothComboBoxesWithBusStopsAsync(int destinationId)
        {
            try
            {
                var selectedDestination = destinations?.FirstOrDefault(d => d.DestinationId == destinationId);

                if (selectedDestination != null && selectedDestination.BusStops != null)
                {
                    var busStopsList = selectedDestination.BusStops.ToList();

                    comboBoxPickup.Items.Clear();
                    comboBoxDestination.Items.Clear();
                    busStopCostDictionary.Clear();

                    foreach (var busStop in busStopsList)
                    {
                        comboBoxPickup.Items.Add(busStop.StopName);
                        comboBoxDestination.Items.Add(busStop.DropStopName);

                        if (double.TryParse(busStop.Cost.ToString(), out double cost))
                        {
                            busStopCostDictionary[$"{busStop.StopName}-{busStop.DropStopName}"] = cost;
                        }
                        else
                        {
                            busStopCostDictionary[$"{busStop.StopName}-{busStop.DropStopName}"] = 0.00;
                        }
                    }

                    if (comboBoxPickup.Items.Count > 0)
                    {
                        comboBoxPickup.SelectedIndex = 0;
                    }

                    if (comboBoxDestination.Items.Count > 0)
                    {
                        comboBoxDestination.SelectedIndex = 0;
                    }
                    UpdateTotalAmount();
                }
                else
                {
                    comboBoxPickup.Items.Clear();
                    comboBoxDestination.Items.Clear();
                    totalAmountTextBox.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                MessageBox.Show($"Error populating combo boxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void loadBookingDetails(BookingDetails bookingInfo, string v)
        {
            dateTimePickerDepartureTime = new CustomTimePicker();
            pickupTime = new CustomTimePicker();
            bookingDatePicker = new CustomDateTimePicker();

            if (bookingInfo != null)
            {
                _bookingID = (int)bookingInfo?.BookingId;

                if (!int.TryParse(GlobalServices.Domainid?.ToString(), out int domainId))
                {
                    MessageBox.Show("Invalid domain ID.");
                    return;
                }

                await LoadDestinationsAsync(domainId);

                bookingNameTextBox.Text = bookingInfo.PassengerDetail?.PassengerName ?? "";
                paymentStatusTextBox.Text = bookingInfo.PaymentType?.Status ?? "";
                numberOfSeatsBookedTextBox.Text = bookingInfo.Vehicle?.NumberOfSeatsAvailable ?? "";
                totalNumberOfPersonTextBox.Text = bookingInfo.TotalNumberOfPerson.ToString();
                roomNumberTextBox.Text = bookingInfo.RoomNumber;
                numberOfGuestTextBox.Text = bookingInfo.NumberOfGuest.ToString();

                if (bookingInfo.Destination != null && bookingInfo.Destination.BusStops != null)
                {
                    await PopulateBothComboBoxesWithBusStopsAsync(bookingInfo.Destination.DestinationId);

                    comboBoxPickup.Text = bookingInfo.PickUpLocation ?? "";
                    comboBoxDestination.Text = bookingInfo.DropOffLocation ?? "";
                    UpdateTotalAmount();
                }
                else
                {
                    comboBoxPickup.Items.Clear();
                    comboBoxDestination.Items.Clear();
                    totalAmountTextBox.Text = "0.00";
                }

                seatNumberTextBox.Text = bookingInfo.SeatNumber;

                if (bookingInfo.BusTiming != null)
                {
                    dateTimePickerDepartureTime.Value = bookingInfo.BusTiming.DepartureTime.GetValueOrDefault();
                    pickupTime.Value = bookingInfo.BusTiming.ArrivalTime.GetValueOrDefault();
                }

                paymentMethodTextBox.Text = bookingInfo.PaymentType?.PaymentWay ?? "";
                bookingStatusCheckBox.Checked = bookingInfo.BookingStatus.GetValueOrDefault(false);
                bookingDatePicker.Value = bookingInfo.BookingDate.GetValueOrDefault(DateTime.Now);
                vehicleTextBox.Text = bookingInfo.Vehicle?.VehicleName ?? "";

                if (bookingInfo.Destination != null)
                {
                    await PopulateBothComboBoxesWithBusStopsAsync(bookingInfo.Destination.DestinationId);
                }
                else
                {
                    comboBoxPickup.Items.Clear();
                    comboBoxDestination.Items.Clear();
                }

                comboBoxDestination.Text = bookingInfo.DropOffLocation ?? "";
                comboBoxPickup.Text = bookingInfo.PickUpLocation ?? "";
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void UpdateTotalAmount()
        {
            if (comboBoxPickup.SelectedIndex >= 0 && comboBoxDestination.SelectedIndex >= 0)
            {
                var selectedPickupStop = comboBoxPickup.SelectedItem.ToString();
                var selectedDestinationStop = comboBoxDestination.SelectedItem.ToString();

                string key = $"{selectedPickupStop}-{selectedDestinationStop}";
                if (busStopCostDictionary.TryGetValue(key, out double cost))
                {
                    totalAmountTextBox.Text = $"${cost:F2}";
                }
                else
                {
                    totalAmountTextBox.Text = "0.00";
                }
            }
            else
            {
                totalAmountTextBox.Text = "0.00";
            }
        }

        public void updateFromSeatChangeScreen(string seatnumber)
        {
            seatNumberTextBox.Text = seatnumber;
        }

        private async Task LoadDestinationsAsync(int domainId)
        {
            try
            {
                ShowTickButtonPictureBox();
                destinations = await MakeHttpGetRequest<List<Destination>>($"api/Destination?domainId={domainId}");

                if (destinations != null && destinations.Count > 0)
                {
                    var placeholder = new Destination { DestinationId = -1, DestinationName = "Select Route" };
                    destinations.Insert(0, placeholder);
                }
                else
                {
                    MessageBox.Show("No destinations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                MessageBox.Show($"Error loading destinations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HideTickButtonPictureBox();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string IsValidForm()
        {
            string errorMessage = null;

            return errorMessage;
        }
        private async Task<T> MakeHttpGetRequest<T>(string endpoint)
        {
            string url = baseUrl + endpoint;
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseData);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"HTTP GET Request Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return default;
        }
        public void ShowTickButtonPictureBox()
        {
            if (tickButtonPictureBox != null)
            {
                tickButtonPictureBox.Visible = true;
                tickButtonPictureBox.BringToFront();
            }
        }
        public void HideTickButtonPictureBox()
        {
            if (tickButtonPictureBox != null)
            {
                tickButtonPictureBox.Visible = false;
            }
        }
        private async void Savebutton_Click(object sender, EventArgs e)
        {
            string errorMessage = IsValidForm();
            if (errorMessage == null)
            {
                ShowTickButtonPictureBox();
                try
                {
                    var responseData = await MakeHttpGetRequest<BookingDetails>("api/Booking/GetBookingById/" + _bookingID);

                    responseData.BookingId = _bookingID;
                    responseData.NumberOfGuest = int.TryParse(numberOfGuestTextBox.Text, out int numberOfGuest) ? numberOfGuest : 0;
                    responseData.RoomNumber = roomNumberTextBox.Text;
                    responseData.BookingStatus = bookingStatusCheckBox.Checked;
                    responseData.TotalNumberOfPerson = int.TryParse(totalNumberOfPersonTextBox.Text, out int totalNumberOfPerson) ? totalNumberOfPerson : 0;
                    responseData.Vehicle.NumberOfSeatsAvailable = numberOfSeatsBookedTextBox.Text;
                    responseData.KidsUnder2Years = int.TryParse(kidsUnder2YearsTextBox.Text, out int kidsUnder2Years) ? kidsUnder2Years : 0;
                    responseData.BookingDate = DateTime.TryParse(bookingDatePicker.Text, out DateTime bookingDate) ? bookingDate : (DateTime?)null;
                    responseData.SeatNumber = seatNumberTextBox.Text;
                    responseData.DomainId = int.Parse(GlobalServices.Domainid.ToString());

                    responseData.PickUpLocation = comboBoxPickup.SelectedItem?.ToString();
                    responseData.DropOffLocation = comboBoxDestination.SelectedItem?.ToString();
                    if (responseData.Destination != null)
                    {
                        if (responseData.Destination.BusStops != null)
                        {
                            responseData.Destination.BusStops.FirstOrDefault().Cost = totalAmountTextBox.Text;
                        }
                    }

                    if (responseData.Vehicle != null)
                    {
                        responseData.Vehicle.VehicleName = vehicleTextBox.Text;
                    }

                    if (responseData.BusTimingId != null)
                    {
                        responseData.BusTiming.DepartureTime = dateTimePickerDepartureTime.Value;
                    }

                    if (responseData.PaymentType != null)
                    {
                        responseData.PaymentType.PaymentWay = paymentMethodTextBox.Text;
                    }

                    if (responseData.BusTiming != null)
                    {
                        responseData.BusTiming.ArrivalTime = pickupTime.Value;
                    }

                    bool response = await MakeHttpPostRequest<BookingDetails>("api/Booking/AddBooking", responseData);

                    HideTickButtonPictureBox();
                    SaveComplete?.Invoke(this, EventArgs.Empty);
                    this.Close();
                    ToasterMessages toaster = new ToasterMessages();

                    if (response && _bookingID == 0)
                    {
                        ShowSuccessPopup();
                    }
                    else if (response && _bookingID > 0)
                    {
                        ShowSuccessPopup();
                    }
                    else
                    {
                        toaster.ShowMessage("Failed to update Booking information!", MessageType.Error);
                        toaster.Show();
                        HideTickButtonPictureBox();
                    }

                    MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                    mainLayoutScreen?.BookingList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in save method: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void ShowSuccessPopup()
        {
            using (Form formBackground = new Form())
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = System.Drawing.Color.Black;
                formBackground.WindowState = FormWindowState.Maximized;
                formBackground.TopMost = true;
                formBackground.Location = this.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();
                Success popup = new Success();
                popup.Owner = formBackground;
                popup.ShowDialog();
            }
        }

        private async Task<bool> MakeHttpPostRequest<T>(string endpoint, object data)
        {
            string url = baseUrl + endpoint;
            string jsonData = JsonConvert.SerializeObject(data);
            HttpContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            bool isSuccess = bool.Parse(responseData);
            return isSuccess;
        }
        private async void LoadData()
        {
            string endpoint = "api/Booking/GetBookingById/" + _bookingID;
            var responseData = await MakeHttpGetRequest<BookingDetails>(endpoint);
            //  loadBookingDetails(responseData, endpoint);
        }

        private void EditBooking_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void seatChangeBtn_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                Location = this.Location,
                ShowInTaskbar = false
            };

            BookingSeatEdit popup = new BookingSeatEdit();
            popup.Owner = formBackground;

            popup.SaveComplete += (s, args) => LoadData();
            popup.loadFromChangeSeat("2-2", _bookingID);

            popup.ShowDialog();
            formBackground.Dispose();
        }

        private string ToTitleCase(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }
        private void bookingNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int selectionStart = textBox.SelectionStart;
                int selectionLength = textBox.SelectionLength;
                textBox.Text = ToTitleCase(textBox.Text);
                textBox.SelectionStart = selectionStart;
                textBox.SelectionLength = selectionLength;
            }
        }

        private void paymentStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int selectionStart = textBox.SelectionStart;
                int selectionLength = textBox.SelectionLength;
                textBox.Text = ToTitleCase(textBox.Text);
                textBox.SelectionStart = selectionStart;
                textBox.SelectionLength = selectionLength;
            }
        }

        private void vehicleTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int selectionStart = textBox.SelectionStart;
                int selectionLength = textBox.SelectionLength;
                textBox.Text = ToTitleCase(textBox.Text);
                textBox.SelectionStart = selectionStart;
                textBox.SelectionLength = selectionLength;
            }
        }

        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();    
        }

        private void comboBoxPickup_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }
    }
}
