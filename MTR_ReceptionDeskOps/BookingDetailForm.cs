using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class BookingDetailForm : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        public long _bookingID = 0;
        public BookingDetails bookingInfo;
        public BookingDetailForm()
        {
            InitializeComponent();
            SetRoundPanel(panelBookingDetails, 15, Color.LightGray);
            SetRoundButton(deletebutton);
            SetRoundButton(editBooking);
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
        private async Task<bool> MakeHttpDeleteRequest<T>(string endpoint)
        {
            string url = baseUrl + endpoint;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            bool isSuccess = bool.Parse(responseData);
            return isSuccess;
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
        public void GetSelectedVehicleId(long Id)
        {
            _bookingID = Id;
            BookingDetailForm_Load();
        }
        private async void deletebutton_Click(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            ToasterMessages toaster = new ToasterMessages();
            var responseData = await MakeHttpDeleteRequest<BookingDetails>("api/Booking/DeleteBookingById/" + _bookingID);
            HideTickButtonPictureBox();
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.BookingList();
            if (responseData)
            {
                toaster.ShowMessage("booking Deleted successfully.!", MessageType.Success);
            }
            else
            {
                toaster.ShowMessage("Failed to delete booking.!", MessageType.Error);
            }
            toaster.Show();
        }
        private void editBooking_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            EditBooking popup = new EditBooking();
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = .50d;
            formBackground.BackColor = System.Drawing.Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.Show();
            popup.Owner = formBackground;
            popup.loadBookingDetails(bookingInfo, "Edit");
            popup.ShowDialog();
            formBackground.Dispose();
        }
        private async void BookingDetailForm_Load()
        {
            try
            {
                ShowTickButtonPictureBox();
                //var responseData = await MakeHttpGetRequest<BookingDetails>("api/Booking/GetBookingById/" + _bookingID);
                //int domainId = int.Parse(GlobalServices.Domainid.ToString());
                //var _vehicle = await MakeHttpGetRequest<List<Vehicles>>($"api/Vehicle/GetAllVehicles?domainId={domainId}"); 
                //var selectedBus = _vehicle.Where(x => x.PlateNumber == responseData.Vehicle.PlateNumber).FirstOrDefault();
                var responseData = await MakeHttpGetRequest<BookingDetails>("api/Booking/GetBookingById/" + _bookingID);
                if (responseData == null)
                {
                    return;
                }

                int domainId;
                if (!int.TryParse(GlobalServices.Domainid?.ToString(), out domainId))
                {
                    return;
                }

                var _vehicle = await MakeHttpGetRequest<List<Vehicles>>($"api/Vehicle/GetAllVehicles?domainId={domainId}");
                if (_vehicle == null)
                {
                    HideTickButtonPictureBox();
                    return;
                }

                var selectedBus = _vehicle?.FirstOrDefault(x => x.PlateNumber == responseData.Vehicle?.PlateNumber);
                if (selectedBus == null)
                {
                    return;
                }

                if (responseData != null)
                {
                    bookingInfo = responseData;
                    bookingName.Text = responseData.PassengerDetail?.PassengerName;
                    pickUpDestination.Text = responseData.PickUpLocation;
                    destinationNameLbl.Text = responseData.DropOffLocation;
                    seatNumber.Text = responseData.SeatNumber;
                    bookingStatuslbl.Text = responseData.BookingStatus == true ? "Active" : "In-Active";
                    paymentMethodlbl.Text = responseData.PaymentType?.PaymentWay;
                    departureTimelbl.Text = responseData.BusTiming?.DepartureTime.ToString();
                    if (!string.IsNullOrWhiteSpace(selectedBus?.VehiclePicture))
                    {
                        UpdateImage(selectedBus.VehiclePicture);
                    }
                    // pickUpDestination.Text = responseData.Destination?.FullAddress;
                    //   destinationNameLbl.Text = responseData.Destination?.DestinationName;
                    //  paymentStatuslbl.Text = responseData.PaymentType?.Status;
                    //  bookingDateLbl.Text = responseData.BookingDate?.ToString();
                    //  destinationIdLbl.Text = responseData.DestinationId?.ToString();
                    //  numberOfGuestLbl.Text = responseData.NumberOfGuest?.ToString();
                    //  staffIdLbl.Text = responseData.StaffId?.ToString();
                    //  roomNumberLbl.Text = responseData.RoomNumber;
                    //  departureOnLbl.Text = responseData.BusTiming?.DepartureTime?.ToString();
                    //  totalNumberOfPersonLbl.Text = responseData.TotalNumberOfPerson?.ToString();
                    //  hotelIdLbl.Text = responseData.HotelId?.ToString();
                    //  totalAmountLbl.Text = responseData.TotalAmount?.ToString();
                    //  travelTimeLbl.Text = responseData.TravelTime?.ToString();
                    //  kidsUnder2YearsLbl.Text = responseData.KidsUnder2Years?.ToString();
                    //  vehicleIdLbl.Text = responseData.VehicleId?.ToString();
                    //  numberOfSeatsBookedLbl.Text = responseData.NumberOfSeatsBooked?.ToString();
                    //  paymentTypeIdLbl.Text = responseData.PaymentTypeId?.ToString();
                    //  passengerIdLbl.Text = responseData.PassangerId?.ToString();
                    //  Set values for nested objects, if they are not null
                    //  passengerNameLbl.Text = responseData.PassengerDetail?.PassengerName;
                }
                HideTickButtonPictureBox();

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error in edit method: {exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void UpdateImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                pictureBox.Image = image;
            }
        }
        private void homeBreadcrumbs_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
        }

        private void bredcrumbBookingList_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.BookingList();
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
    }
}
