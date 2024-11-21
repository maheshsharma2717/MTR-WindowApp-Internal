using Domain.gettaxiusa.com.Entities;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;
using System.Configuration;
using MTRDesktopApplication.Dtos;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Globalization;
using System.Net;

namespace MTRDesktopApplication
{
    public partial class AddBusForm : Form
    {
        public List<HotelDto> selectedHotels = new List<HotelDto>();
        private List<Hotels> Hotels = new List<Hotels>();
        public string SelectedSeat { get; private set; }
        private PictureBox _previouslySelectedPictureBox = null;
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        public long _vehicleID = 0;
        private string _imagePath = string.Empty;
        public event EventHandler SaveComplete;
        public List<Destination> destinations = new List<Destination>();
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
        public void GetSelectedBusId(long Id)
        {
            _vehicleID = Id;
        }
        public AddBusForm()
        {
            InitializeDropDown();
            InitializeComponent();
            this.AutoScroll = true;
            BusModeltextBox.Multiline = true;
            int verticalPadding = (BusModeltextBox.Height - BusModeltextBox.Font.Height) / 2;
            BusModeltextBox.Padding = new Padding(BusModeltextBox.Padding.Left, verticalPadding, BusModeltextBox.Padding.Right, verticalPadding);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            SetRoundPanel(panel2, 5, Color.LightGray);
            SetRoundPanel(panel3, 5, Color.LightGray);
            SetRoundPanel(panel4, 5, Color.LightGray);
            SetRoundPanel(panel5, 5, Color.LightGray);
            SetRoundPanel(panel6, 5, Color.LightGray);
            SetRoundPanel(panel7, 6, Color.LightGray);
            SetRoundPanel(panel8, 6, Color.LightGray);
            SetRoundButton(Savebutton);
            SetRoundButton(UploadBtn);
            MakePanelRounded(colorOutput, 20);
            SetRoundPictureBox(vehiclepictureBox, 20, Color.LightGray);
            InitializeSeatingPlans();
        }
        private void InitializeSeatingPlans()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(flowLayoutPanel);

            for (int i = 0; i < 5; i++)
            {
                SeatingPlanControl seatingPlan = new SeatingPlanControl();
                flowLayoutPanel.Controls.Add(seatingPlan);
            }
        }
        private void AddBusForm_Load(object sender, EventArgs e)
        {
            InitializeDropDown();
        }
        private void SetRoundPictureBox(PictureBox pictureBox, int radius, Color borderColor)
        {
            pictureBox.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(borderColor, 1))
                {
                    Rectangle rect = new Rectangle(0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
                    DrawRoundedRectangle(g, pen, rect, radius);
                }
            };
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(pictureBox.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(pictureBox.Width - radius * 2, pictureBox.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, pictureBox.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            pictureBox.Region = new Region(path);
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
        private async Task<T> MakeHttpGetRequest<T>(string endpoint)
        {
            string url = baseUrl + endpoint;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseData);
            return default;
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
        private void colorPiker_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowHelp = true;
            colorDialog2.AllowFullOpen = false;

            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog2.Color;
                colorOutput.BackColor = selectedColor;
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
            var res = IsValidForm();
            if (res)
            {
                ShowTickButtonPictureBox();
                Vehicles vehicle = new Vehicles
                {
                    VehicleName = BusModeltextBox.Text,
                    PlateNumber = plateNoTextBox.Text,
                    VehicleColor = colorOutput.BackColor.IsKnownColor ? colorOutput.BackColor.Name : GetColorNameFromHex("#" + colorOutput.BackColor.Name),
                    NumberOfSeatsAvailable = seatsTextBox.Text,
                    SeatingPlan = GetSelectedSeatingPlan(),
                    CostPerSeats = decimal.Parse(costTextBox.Text),
                    VehicleId = int.Parse(_vehicleID.ToString()),
                    IsActive = (checkBoxStatus != null && checkBoxStatus.Checked) ? true : false,
                    IsAc = (checkboxIsAc != null && checkboxIsAc.Checked) ? true : false,
                    IsKidsFree = (checkBoxKidsFree != null && checkBoxKidsFree.Checked) ? true : false,
                    DomainId = GlobalServices.Domainid,
                    VehiclePicture = !string.IsNullOrWhiteSpace(_imagePath) ? ImageToBase64(_imagePath) : string.Empty,
                };
                if (Hotels != null)
                {
                    foreach (var item in Hotels)
                    {
                        if (item != null)
                        {
                            vehicle.Hotels.Add(item.HotelId);
                        }
                    };
                }
                        //var selectedDestination = busRouteDropdown.SelectedItem as Domain.gettaxiusa.com.Entities.Destination;
                        //if (selectedDestination != null)
                        //{
                        //    vehicle.Destination = selectedDestination;
                        //    vehicle.DestinationId = selectedDestination.DestinationId;
                        //}
                        bool response = await MakeHttpPostRequest<Vehicles>("api/Vehicle/AddVehicle", vehicle);
                HideTickButtonPictureBox();
                SaveComplete?.Invoke(this, EventArgs.Empty);
                this.Close();
                ToasterMessages toaster = new ToasterMessages();
                if (response && _vehicleID == 0)
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
                else if (response && _vehicleID > 0)
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
                else
                {
                    toaster.ShowMessage("Failed to update Vehicle information!", MessageType.Error);
                    toaster.Show();
                }
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen?.VehicleListScreen();
            }
        }
        private bool IsValidForm()
        {
            bool isValid = true;
            labelBusModalError.Visible = false;
            labelPlateNumberError.Visible = false;
            labelNoOFSeatsError.Visible = false;
            labelCostPerSeatsError.Visible = false;
            labelColorPicker.Visible = false;
            labelSeatingPlanError.Visible = false;
            labelBusRouteError.Visible = false;
            if (string.IsNullOrWhiteSpace(BusModeltextBox.Text))
            {
                labelBusModalError.Visible = true;
                labelBusModalError.Text = "Bus Model can't be empty";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(plateNoTextBox.Text))
            {
                labelPlateNumberError.Visible = true;
                labelPlateNumberError.Text = "Plate Number can't be empty";
                isValid = false;
            }
            //if (busRouteDropdown.SelectedIndex <= 0)
            //{
            //    labelBusRouteError.Visible = true;
            //    labelBusRouteError.Text = "Please select a Bus route";
            //    isValid = false;
            //}
            if (string.IsNullOrWhiteSpace(seatsTextBox.Text))
            {
                labelNoOFSeatsError.Visible = true;
                labelNoOFSeatsError.Text = "Number of seats must be provided";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxSittingPlan.Text))
            {
                labelSeatingPlanError.Visible = true;
                labelSeatingPlanError.Text = "Seating Plan can't be empty";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(costTextBox.Text) || !decimal.TryParse(costTextBox.Text, out _))
            {
                labelCostPerSeatsError.Visible = true;
                labelCostPerSeatsError.Text = "Cost per seats must be a valid number";
                isValid = false;
            }
            return isValid;
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
        private void UpdateImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                vehiclepictureBox.Image = image;
            }
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

                    busRouteDropdown.DisplayMember = "DestinationName";
                    busRouteDropdown.ValueMember = "DestinationId";
                    busRouteDropdown.DataSource = destinations;
                    busRouteDropdown.SelectedIndex = 0;
                    Console.WriteLine("Dropdown data source set successfully.");
                }
                else
                {
                    MessageBox.Show("No destinations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                HideTickButtonPictureBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading destinations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HideTickButtonPictureBox();
            }
        }
        public async void InitializeDropDown()
        {
            if (_vehicleID == null || _vehicleID == 0)
            {
                int domainId = int.Parse(GlobalServices.Domainid.ToString());
                await LoadDestinationsAsync(domainId);
            }
        }
        public async void loadBusDetails(Vehicles busInfo, string? name)
        {
            ShowTickButtonPictureBox();
            int domainId = int.Parse(GlobalServices.Domainid.ToString());
            string endpoint = "api/Hotel/getAll";
            string url = $"{endpoint}?domainId={domainId}";
            List<Hotels> allHotels = await MakeHttpGetRequest<List<Hotels>>(url);
            if (busInfo.Hotels.Count > 0)
            {
                var Hotels = allHotels
                    .Where(hotel => busInfo.Hotels.Contains(hotel.HotelId))
                    .Select(hotel => new HotelDto
                    {
                        HotelId = hotel.HotelId,
                        HotelName = hotel.HotelName,
                        Email = hotel.Email,
                        Address = hotel.Address,
                        HotelNumber = hotel.HotelNumber,
                        ContactNo = hotel.ContactNo,
                        CountryCode = hotel.CountryCode,
                        HotelPicture = hotel.HotelPicture,
                        PlateNumber = hotel.PlateNumber,
                        IsActive = hotel.IsActive,
                        DomainId = hotel.DomainId,
                        HotelStatus = hotel.HotelStatus
                    }).ToList();

                selectedHotels.AddRange(Hotels);

                var formattedHotels = selectedHotels
                    .Select(hotel => $" {hotel.HotelName}")
                    .ToList();

                string commaSeparatedIdsAndNames = string.Join(", ", formattedHotels);
                HotelnumbertextBox.Text = commaSeparatedIdsAndNames;
            }
            await LoadDestinationsAsync(domainId);

            if (destinations != null && destinations.Count > 0)
            {
                var selectedDestination = destinations.FirstOrDefault(d => d.DestinationId == busInfo.Destination?.DestinationId);
                if (selectedDestination != null)
                {
                    await Task.Delay(100);
                    busRouteDropdown.SelectedValue = selectedDestination.DestinationId;
                    Console.WriteLine($"Dropdown selected value set to {selectedDestination.DestinationId}.");
                }
                else
                {
                    Console.WriteLine("Selected destination not found.");
                }

                if (!string.IsNullOrWhiteSpace(busInfo.VehiclePicture))
                {
                    UpdateImage(busInfo.VehiclePicture);
                }
            }
            else
            {
                Console.WriteLine("Destinations data is null or empty.");
            }

            HideTickButtonPictureBox();

            if (name == "Edit")
            {
                Heading.Visible = true;
            }
            _vehicleID = busInfo.VehicleId;
            BusModeltextBox.Text = busInfo.VehicleName;
            plateNoTextBox.Text = busInfo.PlateNumber;
            checkBoxStatus.Checked = busInfo.IsActive.GetValueOrDefault() != false;
            checkBoxKidsFree.Checked = busInfo.IsKidsFree.GetValueOrDefault() != false;
            checkboxIsAc.Checked = busInfo.IsAc.GetValueOrDefault() != false;

            if (!string.IsNullOrEmpty(busInfo.VehicleColor) && !busInfo.VehicleColor.StartsWith("Transparent", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    colorOutput.BackColor = Color.FromName(busInfo.VehicleColor);
                }
                catch (ArgumentException)
                {
                    colorOutput.BackColor = Color.White;
                }
            }

            seatsTextBox.Text = busInfo.NumberOfSeatsAvailable;
            textBoxSittingPlan.Text = busInfo.SeatingPlan;
            HighlightSelectedPictureBox(busInfo.SeatingPlan);
            SetSelectedSeatingPlan(busInfo.SeatingPlan);
            costTextBox.Text = busInfo.CostPerSeats.ToString();
        }
        private void HighlightSelectedPictureBox(string seatingPlan)
        {
            switch (seatingPlan)
            {
                case "2-2":
                    pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "1-2":
                    pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "2-2-5":
                    pictureBox3.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "2-3-6":
                    pictureBox4.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "2-3":
                    pictureBox5.BorderStyle = BorderStyle.FixedSingle;
                    break;
                default:
                    break;
            }
        }
        private void SetSelectedSeatingPlan(string seatingPlan)
        {
            switch (seatingPlan)
            {
                case "2-2":
                    radioButton1.Checked = true;
                    break;
                case "1-2":
                    radioButton2.Checked = true;
                    break;
                case "2-2-5":
                    radioButton3.Checked = true;
                    break;
                case "2-3-6":
                    radioButton4.Checked = true;
                    break;
                case "2-3":
                    radioButton5.Checked = true;
                    break;
                default:
                    break;
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void UploadBtn_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog opnfd = new OpenFileDialog();
        //    opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
        //    if (opnfd.ShowDialog() == DialogResult.OK)
        //    {
        //        vehiclepictureBox.Image = new Bitmap(opnfd.FileName);
        //        _imagePath = opnfd.FileName;
        //    }
        //}
        private void UploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opnfd = new OpenFileDialog())
            {
                opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif)|*.jpg;*.jpeg;*.gif";
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(opnfd.FileName);
                    long fileSizeInKB = fileInfo.Length / 1024;

                    if (fileSizeInKB > 100)
                    {
                        labelVehiclePictureError.Text = "The selected image is too large. Please select an image less than 100KB.";
                        labelVehiclePictureError.Visible = true;
                        vehiclepictureBox.Image = null;
                        _imagePath = null;
                    }
                    else
                    {
                        labelVehiclePictureError.Visible = false;
                        vehiclepictureBox.Image = new Bitmap(opnfd.FileName);
                        _imagePath = opnfd.FileName;
                    }
                }
            }
        }

        public string ImageToBase64(string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException("Image file not found.", imagePath);
            }
            Image image = Image.FromFile(imagePath);
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        private string GetSelectedSeatingPlan()
        {
            if (radioButton1.Checked)
            {
                return "2-2";
            }
            else if (radioButton2.Checked)
            {
                return "1-2";
            }
            else if (radioButton3.Checked)
            {
                return "2-2-5";
            }
            else if (radioButton4.Checked)
            {
                return "2-3-6";
            }
            else if (radioButton5.Checked)
            {
                return "2-3";
            }
            else
            {
                return string.Empty;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SelectedSeat = "2-2";
                textBoxSittingPlan.Text = SelectedSeat;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                SelectedSeat = "1-2";
                textBoxSittingPlan.Text = SelectedSeat;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                SelectedSeat = "2-2-5";
                textBoxSittingPlan.Text = SelectedSeat;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                SelectedSeat = "2-3-6";
                textBoxSittingPlan.Text = SelectedSeat;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                SelectedSeat = "2-3";
                textBoxSittingPlan.Text = SelectedSeat;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HandlePictureBoxSelection(sender as PictureBox);

            PictureBox clickedPictureBox = sender as PictureBox;
            radioButton1.Checked = true;
            clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HandlePictureBoxSelection(sender as PictureBox);
            PictureBox clickedPictureBox = sender as PictureBox;
            clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
            radioButton2.Checked = true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HandlePictureBoxSelection(sender as PictureBox);
            PictureBox clickedPictureBox = sender as PictureBox;
            clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
            radioButton3.Checked = true;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HandlePictureBoxSelection(sender as PictureBox);
            PictureBox clickedPictureBox = sender as PictureBox;
            clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
            radioButton4.Checked = true;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HandlePictureBoxSelection(sender as PictureBox);
            PictureBox clickedPictureBox = sender as PictureBox;
            clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
            radioButton5.Checked = true;
        }
        private void HandlePictureBoxSelection(PictureBox selectedPictureBox)
        {
            if (_previouslySelectedPictureBox != null)
            {
                _previouslySelectedPictureBox.BorderStyle = BorderStyle.None;
            }
            selectedPictureBox.BorderStyle = BorderStyle.FixedSingle;
            _previouslySelectedPictureBox = selectedPictureBox;
        }

        private async void busRouteDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (busRouteDropdown.SelectedItem is Destination selectedDestination)
                {
                    if (selectedDestination.DestinationId == -1)
                    {
                        costTextBox.Text = string.Empty;
                    }
                    else
                    {
                        decimal? cost = null;
                        if (selectedDestination.BusStops?.FirstOrDefault()?.Cost != null)
                        {
                            cost = decimal.Parse(selectedDestination.BusStops.First().Cost);
                        }

                        if (cost.HasValue)
                        {
                            costTextBox.Text = cost.Value.ToString();
                        }
                        else
                        {
                            costTextBox.Text = "Cost not available";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching cost: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ToTitleCase(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }
        private void BusModeltextBox_TextChanged(object sender, EventArgs e)
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

        private void changeHotelId_Click(object sender, EventArgs e)
        {
            using (MultipleHotelId popup = new MultipleHotelId(selectedHotels))
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    selectedHotels.Clear();
                    selectedHotels = popup.SelectedHotels;
                    Hotels.Clear();
                    foreach (var h in selectedHotels)
                    {
                        var ht = new Hotels()
                        {
                            HotelId = h.HotelId,
                            HotelName = h.HotelName,
                            Email = h.Email,
                            Address = h.Address,
                            HotelNumber = h.HotelNumber,
                            ContactNo = h.ContactNo,
                            CountryCode = h.CountryCode,
                            HotelPicture = h.HotelPicture,
                            PlateNumber = h.PlateNumber,
                            IsActive = h.IsActive,
                            DomainId = h.DomainId,
                            HotelStatus = h.HotelStatus
                        };
                        Hotels.Add(ht);
                    }

                    var formattedHotels = selectedHotels
                        .Select(hotel => $" {hotel.HotelName}")
                        .ToList();

                    string commaSeparatedIdsAndNames = string.Join(", ", formattedHotels);
                    HotelnumbertextBox.Text = commaSeparatedIdsAndNames;
                }
            }
        }
    }
}
