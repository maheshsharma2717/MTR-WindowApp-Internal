using Domain.gettaxiusa.com.Entities;
using Newtonsoft.Json;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace MTRDesktopApplication
{
    public partial class HotelDetail : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        public long _hotelID = 0;
        public Hotels HotelInfo;
        private Dictionary<string, string> countryPhoneMasks = new Dictionary<string, string>
        {
            { "+1", "(000) 000-0000" },   // United States
            { "+7", "000-000-0000" },     // Russia
            { "+30", "0000 000 000" },    // Greece
            { "+31", "00 000 0000" },     // Netherlands
            { "+32", "000 00 00 00" },    // Belgium
            { "+33", "00 00 00 00 00" },  // France
            { "+34", "000 00 00 00" },    // Spain
            { "+36", "00 000 0000" },     // Hungary
            { "+39", "000 000 0000" },    // Italy
            { "+40", "0000 000 000" },    // Romania
            { "+41", "00 000 00 00" },    // Switzerland
            { "+43", "000 000 0000" },    // Austria
            { "+44", "0000 000 000" },    // United Kingdom
            { "+45", "00 00 00 00" },     // Denmark
            { "+46", "000-000 00 00" },   // Sweden
            { "+47", "000 00 000" },      // Norway
            { "+48", "000 000 000" },     // Poland
            { "+49", "0000 0000000" },    // Germany
            { "+55", "(00) 00000-0000" }, // Brazil
            { "+57", "(000) 000-0000" },  // Colombia
            { "+61", "00 0000 0000" },    // Australia
            { "+90", "000 000 0000" },    // Turkey
            { "+91", "00000-00000" },     // India
            { "+92", "000 0000000" },     // Pakistan
            { "+98", "000 0000 0000" },   // Iran
            { "+351", "00 000 0000" },    // Portugal
            { "+352", "000 000 000" },    // Luxembourg
            { "+353", "000 000 0000" },   // Ireland
            { "+354", "000 0000" },       // Iceland
            { "+355", "000 000 0000" },   // Albania
            { "+356", "0000 0000" },      // Malta
            { "+357", "00 000000" },      // Cyprus
            { "+358", "00 0000 0000" },   // Finland
            { "+359", "00 000 0000" },    // Bulgaria
            { "+370", "00 000 000" },     // Lithuania
            { "+371", "0000 0000" },      // Latvia
            { "+372", "000 0000" },       // Estonia
            { "+373", "000 000 000" },    // Moldova
            { "+374", "00 000 000" },     // Armenia
            { "+375", "00 000 0000" },    // Belarus
            { "+376", "000 000" },        // Andorra
            { "+377", "00 000 000" },     // Monaco
            { "+378", "00 000 0000" },    // San Marino
            { "+380", "00 000 0000" },    // Ukraine
            { "+381", "00 0000 0000" },   // Serbia
            { "+382", "00 000 000" },     // Montenegro
            { "+383", "00 000 000" },     // Kosovo
            { "+385", "00 000 000" },     // Croatia
            { "+386", "000 000 000" },    // Slovenia
            { "+387", "00 000 000" },     // Bosnia and Herzegovina
            { "+389", "00 000 000" },     // North Macedonia
            { "+420", "000 000 000" },    // Czech Republic
            { "+421", "00 000 0000" },    // Slovakia
            { "+423", "000 000 000" },    // Liechtenstein
            { "+880", "0000-000000" },    // Bangladesh
            { "+964", "000 000 0000" },   // Iraq
            { "+994", "00 000 00 00" },   // Azerbaijan
            { "+995", "000 00 00" },      // Georgia
            { "+213", "00 000 00 00" },   // Algeria
            { "+226", "00 00 00 00" },    // Burkina Faso
            { "+237", "0000 000 000" },   // Cameroon
            { "+242", "00 000 0000" },    // Congo (Republic)
            { "+243", "00 000 000 000" }, // Congo (Democratic Republic)
            { "+225", "00 00 00 00 00" }, // Côte d'Ivoire
            { "+509", "00 00 00 00" },    // Haiti
            { "+62", "0000-0000-0000" },  // Indonesia
            { "+972", "000-000-0000" },   // Israel
            { "+81", "000-0000-0000" },   // Japan
            { "+254", "0000 000 000" },   // Kenya
            { "+82", "00-0000-0000" },    // South Korea
            { "+218", "00 000 0000" },    // Libya
            { "+261", "00 00 000 00" },   // Madagascar
            { "+60", "00-0000 0000" },    // Malaysia
            { "+234", "0000 000 0000" },  // Nigeria
            { "+63", "0000 000 0000" },   // Philippines
            { "+974", "0000 0000" },      // Qatar
            { "+966", "0000 0000" },      // Saudi Arabia
            { "+221", "00 00 000 00" },   // Senegal
            { "+27", "00 000 0000" },     // South Africa
            { "+94", "00 000 0000" },     // Sri Lanka
            { "+255", "00 000 0000" },    // Tanzania
            { "+216", "00 000 000" },     // Tunisia
            { "+256", "000 000 0000" },   // Uganda
            { "+971", "00 000 0000" },    // United Arab Emirates
            { "+84", "00 0000 0000" },    // Vietnam
            { "+260", "00 000 0000" },    // Zambia
            { "+263", "00 000 0000" }     // Zimbabwe
        };

        public HotelDetail()
        {
            InitializeComponent();
            SetRoundButton(EditHotelDetail);
            SetRoundButton(DeleteHotelDetail);
            SetRoundButton(AddHotel);
            SetRoundPanel(panelHotelDetails, 20, Color.LightGray);
            SetRoundPictureBox(pictureBox, 18, Color.Transparent);
        }
        private async void HotelDetail_Load()
        {
            try
            {
                ShowTickButtonPictureBox();
                var responseData = await MakeHttpGetRequest<Hotels>("api/Hotel/GetHotelById/" + _hotelID);
                if (responseData != null)
                {
                    HotelInfo = responseData;
                    //valueHotelId.Text =$"{ responseData.HotelNumber}  |  {responseData.PlateNumber}";
                    valueHotelId.Text = responseData.HotelNumber;
                    HotelName.Text = responseData.HotelName;
                    Address.Text = responseData.Address;
                    HotelNameBredcrumb.Text = responseData.HotelName;
                    if (!string.IsNullOrWhiteSpace(responseData.HotelPicture))
                    {
                        UpdateImage(responseData.HotelPicture);
                    }
                    if (!string.IsNullOrWhiteSpace(responseData.ContactNo))
                    {
                        string formattedPhoneNumber = FormatPhoneNumber(responseData.ContactNo);
                        string countryCode = responseData.CountryCode;
                        string formattedContactNo = $"{countryCode}-{responseData.ContactNo}";

                        phoneNumberTextBox.Text = GetPhoneMask(responseData.ContactNo);
                        phoneNumberTextBox.Text = formattedContactNo;
                    }
                }
                HideTickButtonPictureBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error in edit method: {exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetPhoneMask(string phoneNumber)
        {
            foreach (var mask in countryPhoneMasks)
            {
                if (phoneNumber.StartsWith(mask.Key))
                {
                    return mask.Value;
                }
            }
            return "000-000-0000";
        }
        private string FormatPhoneNumber(string phoneNumber)
        {
            foreach (var mask in countryPhoneMasks)
            {
                if (phoneNumber.StartsWith(mask.Key))
                {
                    return phoneNumber.Substring(mask.Key.Length);
                }
            }
            return phoneNumber;
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
        private void UpdateImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                pictureBox.Image = image;
            }
        }
        private void SetRoundButton(Button button)
        {
            int borderWidth = 2;
            int radius = 15;
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
            IntPtr region = CreateRoundRectRgn(0, 0, panel.Width + 1, panel.Height + 1, diameter, diameter);
            panel.Region = Region.FromHrgn(region);
            DeleteObject(region);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);

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
        public void GetSelectedHotelId(long Id)
        {
            _hotelID = Id;
            HotelDetail_Load();
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
        private async void DeleteHotelDetail_Click(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            var responseData = await MakeHttpDeleteRequest<Hotels>("api/Hotel/DeleteHotelById/" + _hotelID);
            HideTickButtonPictureBox();
            ToasterMessages toaster = new ToasterMessages();
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.HotelListScreen();
            if (responseData)
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
                toaster.ShowMessage("Failed to delete Hotel.!", MessageType.Error);
                toaster.Show();
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
        }
        private void hotelListBredcrum_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.HotelListScreen();
        }
        private void AddHotel_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            AddHotelForm popup = new AddHotelForm();
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
            popup.ShowDialog();
            formBackground.Dispose();
        }
        private void EditHotelDetail_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            AddHotelForm popup = new AddHotelForm();
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = .50d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.Show();
            popup.Owner = formBackground;
            popup.loadHotelData(HotelInfo, "Edit");
            popup.ShowDialog();
            formBackground.Dispose();
        }
    }
}
