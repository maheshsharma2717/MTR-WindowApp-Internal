using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class MultipleHotelId : Form
    {
        public List<HotelDto> _hotelDto = new List<HotelDto>();
        private List<Hotels> allHotels;
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private List<HotelDto> existingHotels;
        private readonly HttpClient httpClient = new HttpClient();

        public List<HotelDto> SelectedHotels { get; private set; } = new List<HotelDto>();

        public MultipleHotelId(List<HotelDto> hotelDto)
        {
            _hotelDto = hotelDto;
            InitializeComponent();
            Load += async (sender, e) =>
            {
                List<HotelDto> hotels = await GenerateHotelDtos();
                if (hotelDto.Count > 0)
                {
                    SelectedHotels.AddRange(_hotelDto);
                }
                foreach (var hotel in hotels)
                {
                    if (SelectedHotels.Any(h => h.HotelId == hotel.HotelId))
                    {
                        hotel.isChecked = true;
                    }
                }
                DisplayHotels(hotels);
            };

            SetRoundButton(Savebutton);
            SetRoundPanel(btnNext, 10, Color.LightGray);
            SetRoundPanel(btnPrevious, 10, Color.LightGray);
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

        private void SetRoundPanel(Panel panel, int radius, Color borderColor)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(borderColor, 1))
                {
                    Rectangle bounds = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                    int diameter = radius * 2;
                    Size size = new Size(diameter, diameter);
                    Rectangle arc = new Rectangle(bounds.Location, size);
                    g.DrawArc(pen, arc, 180, 90);
                    arc.X = bounds.Right - diameter;
                    g.DrawArc(pen, arc, 270, 90);
                    arc.Y = bounds.Bottom - diameter;
                    g.DrawArc(pen, arc, 0, 90);
                    arc.X = bounds.Left;
                    g.DrawArc(pen, arc, 90, 90);
                    g.DrawLine(pen, bounds.Left + radius, bounds.Top, bounds.Right - radius, bounds.Top);
                    g.DrawLine(pen, bounds.Right, bounds.Top + radius, bounds.Right, bounds.Bottom - radius);
                    g.DrawLine(pen, bounds.Left + radius, bounds.Bottom, bounds.Right - radius, bounds.Bottom);
                    g.DrawLine(pen, bounds.Left, bounds.Top + radius, bounds.Left, bounds.Bottom - radius);
                }
            };
            int width = panel.Width;
            int height = panel.Height;
            int diameter = radius * 2;
            int topRect = 0;
            int leftRect = 0;
            int rightRect = width;
            int bottomRect = height;
            int widthEllipse = diameter;
            int heightEllipse = diameter;
            IntPtr region = CreateRoundRectRgn(leftRect, topRect, rightRect + 1, bottomRect + 1, widthEllipse, heightEllipse);
            panel.Region = Region.FromHrgn(region);
            DeleteObject(region);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);

        private async Task<T> MakeHttpGetRequest<T>(string endpoint, int domainId)
        {
            string url = $"{baseUrl}{endpoint}?domainId={domainId}";
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

        private async Task<List<HotelDto>> GenerateHotelDtos()
        {
            List<HotelDto> hotels = new List<HotelDto>();
            int domainId = int.Parse(GlobalServices.Domainid.ToString());
            allHotels = await MakeHttpGetRequest<List<Hotels>>("api/Hotel/getAll", domainId);
            foreach (Hotels h in allHotels)
            {
                var ht = new HotelDto()
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
                hotels.Add(ht);
            }
            return hotels;
        }

        private void DisplayHotels(List<HotelDto> hotels)
        {
            flowLayoutPanel1.Controls.Clear();

            const int checkBoxWidth = 100;
            const int checkBoxHeight = 30;
            Padding checkBoxPadding = new Padding(5);

            foreach (HotelDto hotel in hotels)
            {

                CheckBox checkBox = new CheckBox
                {
                    Text = $"{hotel.HotelName}",
                    AutoSize = false,
                    Width = checkBoxWidth,
                    Height = checkBoxHeight,
                    Font = new Font("Inter SemiBold", 9, FontStyle.Regular),
                    Padding = checkBoxPadding,
                    Margin = checkBoxPadding,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = hotel,
                    Checked = hotel.isChecked,
                };

                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                flowLayoutPanel1.Controls.Add(checkBox);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            HotelDto hotel = (HotelDto)checkBox.Tag;

            if (checkBox.Checked)
            {
                if (!SelectedHotels.Any(h => h.HotelId == hotel.HotelId))
                {
                    SelectedHotels.Add(hotel);
                }
            }
            else
            {
                var hotelToRemove = SelectedHotels.FirstOrDefault(h => h.HotelId == hotel.HotelId);
                if (hotelToRemove != null)
                {
                    SelectedHotels.Remove(hotelToRemove);
                }
            }
        }


        private void Savebutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
