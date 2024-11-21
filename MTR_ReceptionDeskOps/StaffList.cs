using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace MTRDesktopApplication
{
    public partial class StaffList : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 0;
        public StaffList()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            SetRoundButton(AddStaffbutton);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.Padding = new Padding(0);
            SetRoundGrid(dataGridView1, 10, Color.LightGray);
        }
        private async void StaffLists_Load(object sender, EventArgs e)
        {
            await LoadData(currentPage);
            UpdatePaginationLabel();
            SetRoundPanel(NextBtn, 20, Color.LightGray);
            SetRoundPanel(BackBtn, 20, Color.LightGray);
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
            IntPtr region = CreateRoundRectRgnn(leftRect, topRect, rightRect + 1, bottomRect + 1, widthEllipse, heightEllipse);
            panel.Region = Region.FromHrgn(region);
            DeleteObjectt(region);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgnn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObjectt(IntPtr hObject);
        private void SetRoundGrid(DataGridView panel, int radius, Color borderColor)
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
        private async Task<T> MakeHttpGetRequest<T>(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(baseUrl + endpoint);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseData);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"HTTP GET Request Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }
        private async Task<int> GetTotalRecordCount()
        {
            try
            {
                string endpoint = $"api/StaffList/GetStaffListCount";
                return await MakeHttpGetRequest<int>(endpoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total record count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private Image ResizeImage(Image image, int width, int height, int cornerRadius)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(width - cornerRadius, height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseAllFigures();
                g.SetClip(path);
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
        private Image UpdateImage(string base64String, int width, int height, int cornerRadius)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    return ResizeImage(image, width, height, cornerRadius);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Invalid Base64 string format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private async Task LoadData(int page)
        {
            ShowTickButtonPictureBox();
            string endpoint = $"api/StaffList?Domainid={GlobalServices.Domainid}";
            List<StaffListDto> staffList = await MakeHttpGetRequest<List<StaffListDto>>(endpoint);
            if (staffList != null)
            {
                dataGridView1.Rows.Clear();
                int startingIndex = (page - 1) * pageSize + 1;
                foreach (var staff in staffList)
                {
                    Image profileImage;
                    if (!string.IsNullOrWhiteSpace(staff.Profile))
                    {
                        profileImage = UpdateImage(staff.Profile, 50, 50, 55);
                        if (profileImage == null)
                        {
                            profileImage = Properties.Resources.Profile;
                        }
                    }
                    else
                    {
                        profileImage = ResizeImage(Properties.Resources.Profile, 50, 50, 55);
                    }
                    if (profileImage == null)
                    {
                        profileImage = GetPlaceholderImage();
                    }
                    var status = staff.Status == true ? Properties.Resources.active : Properties.Resources.pending;
                    var countryCode = staff.CountryCode ?? "";
                    var cellPhone = !string.IsNullOrWhiteSpace(staff.CellPhone) ? $"({countryCode}) {staff.CellPhone}" : "-";

                    object[] rowData = new object[]
                    {
                      startingIndex++,
                      staff.Id,
                      profileImage,
                      staff.FirstName,
                      cellPhone,
                      staff.Email,
                      status,
                    };
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows.Add(rowData);
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 255, 255);
                }
                // int totalRecords = await GetTotalRecordCount();
               // totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                UpdatePaginationLabel();
            }
            else
            {
                MessageBox.Show("No Staff found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HideTickButtonPictureBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["viewMore"].Index)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen.StaffDetails(id);
            }
        }
        private Image GetPlaceholderImage()
        {
            Bitmap placeholder = new Bitmap(57, 57);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.Gray);
                g.DrawString("N/A", new Font("Arial", 12), Brushes.Black, new PointF(10, 20));
            }
            return placeholder;
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
        private void UpdatePaginationLabel()
        {
            labelPagination.Text = $"Page {currentPage} of {totalPages}";
        }
        private async void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                await LoadData(currentPage);
                UpdatePaginationLabel();
            }
        }
        private async void BackBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadData(currentPage);
                UpdatePaginationLabel();
            }
        }
        private void homeBredcrumb_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
        }
        private void AddStaffbutton_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            AddStaff popup = new AddStaff();
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
            popup.ShowDialog();
            formBackground.Dispose();
        }
    }
}