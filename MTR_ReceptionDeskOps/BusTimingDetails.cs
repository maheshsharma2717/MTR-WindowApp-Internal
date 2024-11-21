using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class BusTimingDetails : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        public int _bustimingID = 0;
        public BusTimingDto busInfo;
        public BusTimingDetails()
        {
            InitializeComponent();
            SetRoundButton(AddBusTiming);
            SetRoundButton(editBusTiming);
            SetRoundButton(deletebutton);
            SetRoundPanel(panelBusTimingDetail, 20, Color.LightGray);
            SetRoundPanel(colorPanel, 20, Color.Transparent);
            SetRoundPictureBox(pictureBox, 17, Color.Transparent);
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
        private void SetRoundPanel(Panel panel, int radius, Color borderColor)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.Paint += (sender, e) =>
            {
                DrawRoundedBorder(panel, radius, borderColor, e.Graphics);
            };
            panel.SizeChanged += (sender, e) =>
            {
                UpdateRoundedRegion(panel, radius);
            };
            UpdateRoundedRegion(panel, radius);
        }
        private void DrawRoundedBorder(Control panel, int radius, Color borderColor, Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(borderColor, 1))
            {
                int diameter = radius * 2;
                Size size = new Size(diameter, diameter);
                Rectangle bounds = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

                GraphicsPath path = new GraphicsPath();
                path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseAllFigures();
                g.DrawPath(pen, path);
            }
        }
        private void UpdateRoundedRegion(Control panel, int radius)
        {
            int diameter = radius * 2;
            IntPtr region = CreateRoundRectRgnn(0, 0, panel.Width + 1, panel.Height + 1, diameter, diameter);
            panel.Region = Region.FromHrgn(region);
            DeleteObjectt(region);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgnn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObjectt(IntPtr hObject);
        private bool IsHexadecimal(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c) && !((c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F')))
                {
                    return false;
                }
            }
            return true;
        }
        private async void BusTimingDetails_Load(object sender, EventArgs e)
        {
            try
            {
                ShowTickButtonPictureBox();
                int domainId = int.Parse(GlobalServices.Domainid.ToString());
                var _vehicle = await MakeHttpGetRequest<List<Vehicles>>($"api/Vehicle/GetAllVehicles?domainId={domainId}");
                var responseData = await MakeHttpGetRequest<BusTimingDto>("api/BusTiming/GetBusTimingById/" + _bustimingID);
                var selectedBus = _vehicle.Where(x => x.PlateNumber == responseData.PlateNumber).FirstOrDefault();
                if (responseData != null)
                {
                    busInfo = responseData;
                    string colorString = responseData.Color;
                    if (colorString.Length == 8 && IsHexadecimal(colorString.Substring(0, 6)))
                    {
                        Color backColor = ColorTranslator.FromHtml("#" + colorString.Substring(0, 6));
                        colorPanel.BackColor = backColor;
                        valueColor.Text = colorString;
                        colorPanel.BackColor = ColorTranslator.FromHtml("#" + colorString);
                    }
                    else
                    {
                        valueColor.Text = responseData.Color;
                        colorPanel.BackColor = ColorTranslator.FromHtml(responseData.Color);
                    }
                    valueModel.Text = responseData.Model;
                    valuePlateNo.Text = responseData.PlateNumber;
                    valueSeatingPlan.Text = responseData.SeatingPlan;
                    valueNoOfSeats.Text = responseData.NumberOfSeatsAvailable;
                    valueDeparture.Text = responseData.DepartureTime.ToString();
                    valueArrival.Text = responseData.ArrivalTime.ToString();
                    if (!string.IsNullOrWhiteSpace(selectedBus?.VehiclePicture))
                    {
                        UpdateImage(selectedBus.VehiclePicture);
                    }
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
        public void GetSelectedBusTimingId(int Id)
        {
            _bustimingID = Id;
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
        private async Task<bool> MakeHttpDeleteRequest<T>(string endpoint)
        {
            string url = baseUrl + endpoint;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            bool isSuccess = bool.Parse(responseData);
            return isSuccess;
        }
        private async void deletebutton_Click_1(object sender, EventArgs e)
        {
            ToasterMessages toaster = new ToasterMessages();
            var responseData = await MakeHttpDeleteRequest<BusTimingDto>("api/BusTiming/DeleteBusTimingById/" + _bustimingID);

            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.BusTiming();
            if (responseData)
            {
                //  toaster.ShowMessage("Bus Timing Deleted successfully.!", MessageType.Success);
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
                toaster.ShowMessage("Failed to delete Bus Timing.!", MessageType.Error);
                toaster.Show();
            }
           
        }
        private void AddBusTiming_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = 0.50d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            AddBusTiming addBustiming = new AddBusTiming();
            addBustiming.Owner = formBackground;
            formBackground.Show();
            addBustiming.ShowDialog();
            formBackground.SendToBack();
            formBackground.Dispose();
        }
        private void editBusTiming_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = 0.50d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            AddBusTiming addBustiming = new AddBusTiming();
            addBustiming.Owner = formBackground;
            formBackground.Show();
            addBustiming.loadBustimingDetails(busInfo, "Edit" );
            addBustiming.ShowDialog();
            formBackground.SendToBack();
            formBackground.Dispose();
        }
        private void homeBreadcrumbs_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
        }
        private void busTimingBreadcrumbs_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.BusTiming();
        }
    }
}

