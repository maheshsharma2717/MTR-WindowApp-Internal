using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace MTRDesktopApplication
{
    public partial class HotelList : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private int currentPage = 1;
        private int pageSize = 8;
        private int totalPages = 0;
        private List<Hotels> allHotels;
        public HotelList()
        {
            InitializeComponent();
            Load += HotelList_Load;
            SetRoundButton(AddHotel);
            SetRoundButton(SearchButton);
            SetRoundPanel(BackBtn, 20, Color.LightGray);
            SetRoundPanel(NextBtn, 20, Color.LightGray);
            SetRoundPanels(panelSearch, 7, Color.LightGray);
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
        private void SetRoundPanels(Panel panel, int radius, Color borderColor)
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
        private Image UpdateImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        private async void HotelList_Load(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            int domainId = int.Parse(GlobalServices.Domainid.ToString());
            allHotels = await MakeHttpGetRequest<List<Hotels>>("api/Hotel/getAll", domainId);
            await LoadData(allHotels);
            UpdatePaginationLabel();
            HideTickButtonPictureBox();
        }

        private async Task LoadData(List<Hotels> hotels)
        {
            ShowTickButtonPictureBox();
            if (hotels != null && hotels.Any())
            {
                hotel_List_Main_Layout.Controls.Clear();
                foreach (var hotel in hotels)
                {
                    Panel inside_panel = new Panel();
                    inside_panel.Width = 680;
                    inside_panel.Height = 200;
                    inside_panel.BorderStyle = BorderStyle.FixedSingle;
                    inside_panel.BackColor = Color.FromArgb(230, 255, 255);
                    inside_panel.Location = new Point(90, 90);
                    inside_panel.Margin = new Padding(25, 15, 25, 15);
                    inside_panel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    // PictureBox hotel
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(130, 130);
                    pictureBox.Location = new Point(27, 35);
                    inside_panel.Controls.Add(pictureBox);
                    if (!string.IsNullOrWhiteSpace(hotel.HotelPicture))
                    {
                        pictureBox.Image = UpdateImage(hotel.HotelPicture);
                    }
                    // Label for hotelName
                    Label hotelNameLabel = new Label();
                    hotelNameLabel.Text = hotel.HotelName;
                    hotelNameLabel.Font = new Font("inter", 15, FontStyle.Bold);
                    hotelNameLabel.AutoSize = true;
                    hotelNameLabel.Location = new Point(200, 40);
                    inside_panel.Controls.Add(hotelNameLabel);
                    //PictureBox location
                    PictureBox locationPicture = new PictureBox();
                    locationPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    locationPicture.Size = new Size(15, 19);
                    locationPicture.Location = new Point(200, 93);
                    locationPicture.Image = Properties.Resources.LocationIcon;
                    locationPicture.BringToFront();
                    inside_panel.Controls.Add(locationPicture);
                    //Label for address
                    Label addressLabel = new Label();
                    addressLabel.Text = hotel.Address;
                    addressLabel.Font = new Font("inter", 12);
                    addressLabel.AutoSize = false;
                    addressLabel.Width = 300;
                    addressLabel.Location = new Point(220, 90);
                    addressLabel.TextAlign = ContentAlignment.TopLeft;
                    using (Graphics g = addressLabel.CreateGraphics())
                    {
                        SizeF textSize = g.MeasureString(addressLabel.Text, addressLabel.Font, addressLabel.Width);
                        addressLabel.Height = (int)Math.Ceiling(textSize.Height);
                    }
                    inside_panel.Controls.Add(addressLabel);
                    //Button View more 
                    Button viewMoreButton = new Button();
                    viewMoreButton.Text = "View More";
                    viewMoreButton.Name = "view";
                    viewMoreButton.Size = new Size(125, 47);
                    viewMoreButton.Location = new Point(525, 73);
                    viewMoreButton.BackColor = Color.FromArgb(0, 214, 220);
                    viewMoreButton.FlatStyle = FlatStyle.Flat;
                    viewMoreButton.ForeColor = Color.White;
                    viewMoreButton.Font = new Font("Inter", 9, FontStyle.Bold);
                    viewMoreButton.FlatAppearance.BorderSize = 0;
                    viewMoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 214, 220);
                    viewMoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 214, 220);
                    viewMoreButton.FlatAppearance.BorderSize = 1;
                    viewMoreButton.FlatAppearance.BorderColor = Color.FromArgb(0, 214, 220);
                    viewMoreButton.Click += ViewMoreButton_Click;
                    viewMoreButton.Tag = hotel.HotelId;
                    GraphicsPath buttonPath = new GraphicsPath();
                    Rectangle buttonBounds = viewMoreButton.ClientRectangle;
                    int buttonRadius = 10;
                    buttonPath.AddArc(buttonBounds.X, buttonBounds.Y, buttonRadius, buttonRadius, 180, 90);
                    buttonPath.AddArc(buttonBounds.X + buttonBounds.Width - buttonRadius, buttonBounds.Y, buttonRadius, buttonRadius, 270, 90);
                    buttonPath.AddArc(buttonBounds.X + buttonBounds.Width - buttonRadius, buttonBounds.Y + buttonBounds.Height - buttonRadius, buttonRadius, buttonRadius, 0, 90);
                    buttonPath.AddArc(buttonBounds.X, buttonBounds.Y + buttonBounds.Height - buttonRadius, buttonRadius, buttonRadius, 90, 90);
                    buttonPath.CloseFigure();
                    viewMoreButton.Region = new Region(buttonPath);
                    inside_panel.Controls.Add(viewMoreButton);
                    hotel_List_Main_Layout.Controls.Add(inside_panel);
                    SetRoundPanel(inside_panel, 15, Color.LightGray);
                    SetRoundPictureBox(pictureBox, 18, Color.Transparent);
                }
                int totalRecords = await GetTotalRecordCount();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            }
            else
            {
                MessageBox.Show("No hotels found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HideTickButtonPictureBox();
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
        private async Task<int> GetTotalRecordCount()
        {
            string countEndpoint = $"api/Hotel/GetHotelCount";
            int totalCount = await MakeHttpGetRequest<int>(countEndpoint);
            return totalCount;
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
        private void UpdatePaginationLabel()
        {
            PaginationLbl.Text = $"Page {currentPage} of {totalPages}";
        }
        private void ViewMoreButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string id = button.Tag.ToString();
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.HotelDetail(int.Parse(id));
        }
        private void Home_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
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
            //formBackground.Show();
            popup.Owner = formBackground;
            popup.ShowDialog();
            formBackground.Dispose();
        }
        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                // await LoadData(currentPage);
                UpdatePaginationLabel();
            }
        }
        private async void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                // await LoadData(currentPage);
                UpdatePaginationLabel();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            string searchTerm = SearchBarHotel.Text.Trim();
            if (allHotels != null && allHotels.Any() && !string.IsNullOrWhiteSpace(searchTerm))
            {
                List<Hotels> filteredHotels = allHotels
                     .Where(hotel =>
                         hotel.HotelName.ToLower().Contains(searchTerm.ToLower()) ||
                         hotel.Address.ToLower().Contains(searchTerm.ToLower()))
                     //hotel.Description.ToLower().Contains(searchTerm.ToLower())) // Example: additional property
                     .ToList();
                LoadData(filteredHotels);
            }
            else
            {
                LoadData(allHotels);
            }
        }
    }
}
