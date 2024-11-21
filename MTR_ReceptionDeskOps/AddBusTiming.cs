using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.CustomControls;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System.Configuration;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
namespace MTRDesktopApplication
{
    public partial class AddBusTiming : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        public int _bustimingID = 0;
        public List<Destination> destinations = new List<Destination>();
        public event EventHandler SaveComplete;
        public List<Vehicles> _vehicle = new List<Vehicles>();
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgng(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void MakePanelRounded(Panel panel, int radius)
        {
            int width = panel.Width;
            int height = panel.Height;
            int diameter = radius * 2;
            int topRect = 0;
            int leftRect = 0;
            int rightRect = width;
            int bottomRect = height;
            int widthEllipse = diameter;
            int heightEllipse = diameter;
            IntPtr region = CreateRoundRectRgng(leftRect, topRect, rightRect + 1, bottomRect + 1, widthEllipse, heightEllipse);
            panel.Region = Region.FromHrgn(region);
            DeleteObject(region);
        }
        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        public AddBusTiming()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            SetRoundPanel(panel3, 5, Color.LightGray);
            SetRoundPanel(panel4, 5, Color.LightGray);
            SetRoundPanel(panel5, 5, Color.LightGray);
            SetRoundPanel(panel6, 5, Color.LightGray);
            SetRoundPanel(panel7, 5, Color.LightGray);
            SetRoundPanel(panel8, 5, Color.LightGray);
            SetRoundPanel(panel1, 5, Color.LightGray);
            SetRoundPanel(panel9, 5, Color.LightGray);
            MakePanelRounded(colorPikerTextBox, 20);
            SetRoundButton(Savebutton);
            dateTimePickerDepartureTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerDepartureTime.CustomFormat = "h:mm tt";
            dateTimePickerArrivalTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerArrivalTime.CustomFormat = "h:mm tt";
            InitializeCustomTimePicker();
        }

        private async Task<T> MakeHttpGetRequest<T>(string endpoint)
        {
            string url = baseUrl + endpoint;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseData);
            return default;
        }
        private void InitializeCustomTimePicker()
        {
            CustomTimePicker timePicker = new CustomTimePicker
            {
                Location = new Point(5, 5),
                Size = new Size(200, 35),
                SkinColor = Color.MediumSlateBlue,
                TextColor = Color.White,
                BorderColor = Color.PaleVioletRed,
                BorderSize = 2
            };

            this.Controls.Add(timePicker);
        }
        private void SetRoundButton(Button button)
        {
            int borderWidth = 2;
            int radius = 10;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = button.ClientRectangle;
            bounds.Inflate(-borderWidth, -borderWidth);
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }
        public void GetSelectedBusId(int Id)
        {
            _bustimingID = Id;
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
        private void colorPikertiming_Click(object sender, EventArgs e)
        {
            colorDialog.ShowHelp = true;
            colorDialog.AllowFullOpen = false;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                colorPikerTextBox.BackColor = selectedColor;
            }
        }
        public static string GetColorNameFromHex(string hex)
        {
            Color color = ColorTranslator.FromHtml(hex);
            string closestColorName = GetClosestColorName(color);
            return closestColorName;
        }
        private static string GetClosestColorName(Color color)
        {
            string closestColorName = "Unknown";
            int minDistance = int.MaxValue;
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color knownColorValue = Color.FromKnownColor(knownColor);
                int distance = CalculateColorDistance(color, knownColorValue);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestColorName = knownColor.ToString();
                }
            }
            return closestColorName;
        }
        private static int CalculateColorDistance(Color color1, Color color2)
        {
            int rDiff = Math.Abs(color1.R - color2.R);
            int gDiff = Math.Abs(color1.G - color2.G);
            int bDiff = Math.Abs(color1.B - color2.B);
            return rDiff + gDiff + bDiff;
        }

        private async void Savebutton_Click(object sender, EventArgs e)
        {
            string errorMessage = IsValidForm();
            if (errorMessage == null)
            {
                ShowTickButtonPictureBox();
                BusTimingDto busTiming = new BusTimingDto();
                busTiming.BusTimingId = _bustimingID;
                busTiming.Model = BusModeltextBox.Text;
                busTiming.PlateNumber = comboBoxNumberPlate.Text;
                busTiming.NumberOfSeatsAvailable = seatsTextBox.Text;
                busTiming.Color = colorPikerTextBox.BackColor.IsKnownColor ? colorPikerTextBox.BackColor.Name : GetColorNameFromHex("#" + colorPikerTextBox.BackColor.Name);
                busTiming.SeatingPlan = textBoxSeatingPlan.Text;
                var selectedDestination = busRouteDropdown.SelectedItem as Destination;
                if (selectedDestination != null)
                {
                    busTiming.Destination = selectedDestination;
                    busTiming.DestinationId = selectedDestination.DestinationId;
                }
                busTiming.DepartureTime = DateTime.TryParse(dateTimePickerDepartureTime.Text, out DateTime departure) ? departure : (DateTime?)null;
                busTiming.ArrivalTime = DateTime.TryParse(dateTimePickerArrivalTime.Text, out DateTime arrival) ? arrival : (DateTime?)null;
                busTiming.DomainId = int.Parse(GlobalServices.Domainid);
                bool response = await MakeHttpPostRequest<BusTimingDto>("api/BusTiming/AddBusTiming", busTiming);
                HideTickButtonPictureBox();
                SaveComplete?.Invoke(this, EventArgs.Empty);
                this.Close();

                ToasterMessages toaster = new ToasterMessages();
                if (response)
                {
                    ShowSuccessPopup();
                }
                else
                {
                    toaster.ShowMessage("Failed to update Vehicle information!", MessageType.Error);
                    toaster.Show();
                }

                var mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen?.BusTiming();
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

        private string IsValidForm()
        {
            string errorMessage = null;
            labelBusModalError.Visible = false;
            labelPlateNumberError.Visible = false;
            labelNoOFSeatsError.Visible = false;
            labelColorPicker.Visible = false;
            labelSeatingPlanError.Visible = false;
            labelBusRouteError.Visible = false;
            if (string.IsNullOrWhiteSpace(BusModeltextBox.Text))
            {
                labelBusModalError.Visible = true;
                labelBusModalError.Text = "Bus Model can't be empty";
                errorMessage = "Bus Model can't be empty";
            }
            if (comboBoxNumberPlate.SelectedIndex <= 0)
            {
                labelPlateNumberError.Visible = true;
                labelPlateNumberError.Text = "Please select a Plate Number";
                errorMessage = "Please select a Plate Number.";
            }
            if (string.IsNullOrWhiteSpace(seatsTextBox.Text))
            {
                labelNoOFSeatsError.Visible = true;
                labelNoOFSeatsError.Text = "Number of seats must be provided";
                errorMessage = "Number of seats must be provided";
            }
            if (string.IsNullOrWhiteSpace(textBoxSeatingPlan.Text))
            {
                labelSeatingPlanError.Visible = true;
                labelSeatingPlanError.Text = "Enter a Seating Plan";
                errorMessage = "Enter a Seating Plan";
            }
            if (busRouteDropdown.SelectedIndex <= 0)
            {
                labelBusRouteError.Visible = true;
                labelBusRouteError.Text = "Please select a Bus route";
                errorMessage = "Please select a Bus route";
            }
            return errorMessage;
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
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void comboBoxNumberPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPlateNumber = comboBoxNumberPlate.Text;
            Vehicles selectedVehicle = _vehicle.FirstOrDefault(v => v.PlateNumber == selectedPlateNumber);

            if (selectedVehicle != null)
            {
                BusModeltextBox.Text = selectedVehicle.VehicleName;
                seatsTextBox.Text = selectedVehicle.NumberOfSeatsAvailable?.ToString();
                colorPikerTextBox.BackColor = string.IsNullOrWhiteSpace(selectedVehicle.VehicleColor)
                    ? Color.White
                    : Color.FromName(selectedVehicle.VehicleColor);
                textBoxSeatingPlan.Text = selectedVehicle.SeatingPlan;
                comboBoxNumberPlate.Text = selectedVehicle.PlateNumber;
            }
        }

        private async void AddBusTiming_Load(object sender, EventArgs e)
        {
            if (_bustimingID == null || _bustimingID == 0)
            {
                await InitializeDropDown();
                await InitializeDropDownDestination();
            }
        }

        private async void busRouteDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busRouteDropdown.SelectedValue is int selectedDestinationId && selectedDestinationId > 0)
            {
                await LoadBusStopsAsync(selectedDestinationId);
            }
            else
            {
                listBoxBusStops.DataSource = null;
            }
        }

        private async Task LoadBusStopsAsync(int destinationId)
        {
            try
            {
                ShowTickButtonPictureBox();
                int domainId = int.Parse(GlobalServices.Domainid.ToString());
                var busStops = await MakeHttpGetRequest<List<BusStops>>($"api/BusStops/GetAllBusStopByDestinationId?destinationId={destinationId}&domainId={domainId}");
                if (busStops != null && busStops.Count > 0)
                {
                    listBoxBusStops.DisplayMember = "StopName";
                    listBoxBusStops.ValueMember = "StopId";
                    listBoxBusStops.DataSource = busStops;
                    listBoxBusStops.SelectedIndex = 0;
                }
                else
                {
                    HideTickButtonPictureBox();
                    MessageBox.Show("No bus stops found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                HideTickButtonPictureBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bus stops: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HideTickButtonPictureBox();
            }
        }

        private async Task InitializeDropDown()
        {
            ShowTickButtonPictureBox();
            try
            {
                int domainId = int.Parse(GlobalServices.Domainid.ToString());
                _vehicle = await MakeHttpGetRequest<List<Vehicles>>($"api/Vehicle/GetAllVehicles?domainId={domainId}");

                if (_vehicle != null)
                {
                    var placeholder = new Vehicles { VehicleId = -1, PlateNumber = "Select Number Plate" };
                    _vehicle.Insert(0, placeholder);
                    comboBoxNumberPlate.DataSource = _vehicle;
                    comboBoxNumberPlate.DisplayMember = "PlateNumber";
                    comboBoxNumberPlate.ValueMember = "VehicleId";
                    comboBoxNumberPlate.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No vehicles found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HideTickButtonPictureBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing dropdown: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideTickButtonPictureBox();
        }

        private async Task InitializeDropDownDestination()
        {
            if (_bustimingID == null || _bustimingID == 0)
            {
                int domainId = int.Parse(GlobalServices.Domainid.ToString());
                await LoadDestinationsAsync(domainId);
            }
        }

        private async Task LoadDestinationsAsync(int domainId)
        {
            try
            {
                //ShowTickButtonPictureBox();
                destinations = await MakeHttpGetRequest<List<Destination>>($"api/Destination?domainId={domainId}");

                if (destinations != null && destinations.Count > 0)
                {
                    var placeholder = new Destination { DestinationId = -1, DestinationName = "Select Route -" };
                    destinations.Insert(0, placeholder);
                    busRouteDropdown.DisplayMember = "DisplayName";
                    busRouteDropdown.ValueMember = "DestinationId";
                    busRouteDropdown.DataSource = destinations;
                    busRouteDropdown.SelectedIndex = 0;

                    Console.WriteLine("Dropdown data source set successfully.");
                }
                else
                {
                    MessageBox.Show("No destinations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //HideTickButtonPictureBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading destinations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HideTickButtonPictureBox();
            }
        }
       
        public async void loadBustimingDetails(BusTimingDto busInfo, string? name)
        {
            try
            {
                ShowTickButtonPictureBox();
                _bustimingID = (int)busInfo.BusTimingId;
                int domainId = int.Parse(GlobalServices.Domainid.ToString());

                await InitializeDropDown();
                await LoadDestinationsAsync(domainId);

                if (destinations != null && destinations.Count > 0)
                {
                    var selectedDestination= destinations.FirstOrDefault(x=>x.DestinationId==busInfo.DestinationId);
                    //var selectedDestination = destinations.FirstOrDefault(d => d.DestinationId == busInfo.Destination?.DestinationId);
                    if (selectedDestination != null)
                    {
                        busRouteDropdown.SelectedValue = selectedDestination.DestinationId;
                        Console.WriteLine($"Dropdown selected value set to {selectedDestination.DestinationId}.");
                    }
                    else
                    {
                        Console.WriteLine("Selected destination not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Destinations data is null or empty.");
                }

                if (name == "Edit")
                {
                    Heading.Visible = true;
                }

                BusModeltextBox.Text = busInfo.Model ?? string.Empty;
                comboBoxNumberPlate.Text = busInfo.PlateNumber ?? string.Empty;
                seatsTextBox.Text = busInfo.NumberOfSeatsAvailable ?? string.Empty;

                if (!string.IsNullOrEmpty(busInfo.Color) && !busInfo.Color.StartsWith("Transparent", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        colorPikerTextBox.BackColor = Color.FromName(busInfo.Color);
                    }
                    catch (ArgumentException)
                    {
                        colorPikerTextBox.BackColor = Color.White;
                    }
                }

                textBoxSeatingPlan.Text = busInfo.SeatingPlan ?? string.Empty;

                if (busInfo.DepartureTime.HasValue)
                {
                    dateTimePickerDepartureTime.Value = busInfo.DepartureTime.Value;
                }
                else
                {
                    MessageBox.Show("Pick a departure time.");
                }

                if (busInfo.ArrivalTime.HasValue)
                {
                    dateTimePickerArrivalTime.Value = busInfo.ArrivalTime.Value;
                }
                else
                {
                    MessageBox.Show("Pick an arrival time.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HideTickButtonPictureBox();
            }
        }

    }
}
