using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
namespace MTRDesktopApplication
{
    public partial class BookingLists : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 0;
        public BookingLists()
        {
            InitializeComponent();
            SetRoundPanel(BackBtn, 20, Color.LightGray);
            SetRoundPanel(NextBtn, 20, Color.LightGray);
            SetRoundPanel(recentBtn, 5, Color.LightGray);
            SetRoundGrid(dataGridView1, 10, Color.LightGray);
        }
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
            IntPtr region = CreateRoundRectRgnt(leftRect, topRect, rightRect + 1, bottomRect + 1, widthEllipse, heightEllipse);
            panel.Region = Region.FromHrgn(region);
            DeleteObjectn(region);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgnt(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObjectn(IntPtr hObject);
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
                string endpoint = $"api/Booking/GetBookingCount";
                return await MakeHttpGetRequest<int>(endpoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total record count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private async void BookingList_Load(object sender, EventArgs e)
        {
            await LoadData(currentPage);
            UpdatePaginationLabel();
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }
        private async Task LoadData(int page)
        {
            ShowTickButtonPictureBox();
            string endpoint = $"api/Booking?pageNumber={page}&pageSize={pageSize}&Domainid={GlobalServices.Domainid}";
            List<BookingDetails> booking = await MakeHttpGetRequest<List<BookingDetails>>(endpoint);
            if (booking != null)
            {
                dataGridView1.Rows.Clear();
                List<object[]> data = new List<object[]>();
                int startingIndex = (page - 1) * pageSize + 1;
                for (int i = 0; i < booking.Count; i++)
                {
                    var bookingDetail = booking[i];
                    object[] rowData = new object[]
                    {
                     startingIndex + i,
                     bookingDetail.BookingId,
                     bookingDetail.PassengerDetail?.PassengerName,
                     bookingDetail.PickUpLocation,
                   //  bookingDetail.Destination?.FullAddress,
                     bookingDetail.SeatNumber,
                     bookingDetail.BookingStatus == true ? "Active": "In-Active",
                     bookingDetail.BusTiming?.DepartureTime,
                     bookingDetail.PaymentType?.PaymentWay,
                     bookingDetail.PaymentType?.Status,
                    };
                    data.Add(rowData);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                foreach (var row in data)
                {
                    dataGridView1.Rows.Add(row);
                }
                int totalRecords = await GetTotalRecordCount();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
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
        private void UpdatePaginationLabel()
        {
            labelPagination.Text = $"Page {currentPage} of {totalPages}";
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["viewMore"].Index)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen.BookingDetailForm(id);
            }
        }
        private async Task LoadRecentData()
        {
            string orderBy = "Created";
            string orderDirection = "desc";
            string endpoint = $"api/Booking?pageNumber={currentPage}&pageSize={pageSize}&orderBy={orderBy}&orderDirection={orderDirection}&Domainid={GlobalServices.Domainid}";
            List<BookingDetails> recentBookings = await MakeHttpGetRequest<List<BookingDetails>>(endpoint);
            if (recentBookings != null)
            {
                dataGridView1.Rows.Clear();
                List<object[]> data = new List<object[]>();
                int startingIndex = (currentPage - 1) * pageSize + 1;
                foreach (var bookingDetail in recentBookings)
                {
                    object[] rowData = new object[]
                    {
                     startingIndex++,
                     bookingDetail.BookingId,
                     bookingDetail.PassengerDetail.PassengerName,
                    // bookingDetail?.Destination?.DestinationName,
                     bookingDetail?.DropOffLocation,
                     bookingDetail.SeatNumber,
                     bookingDetail.BookingStatus == true ? "Active": "In-Active",
                     bookingDetail.BusTiming.DepartureTime,
                     bookingDetail?.PaymentType?.PaymentWay,
                     bookingDetail?.PaymentType?.Status,
                     deleteImage.Images.Count>0?deleteImage.Images[1]:null
                    };
                    data.Add(rowData);
                }
                foreach (var row in data)
                {
                    dataGridView1.Rows.Add(row);
                }
                UpdatePaginationLabel();
            }
        }

        private void homeBreadcrumb_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
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
        private void labelRecent_Click(object sender, EventArgs e)
        {
            LoadRecentData();
        }
        private void downArrow_Click(object sender, EventArgs e)
        {
            LoadRecentData();
        }
        private void recent_Click(object sender, EventArgs e)
        {
            LoadRecentData();
        }
        private void recentBtn_Click(object sender, EventArgs e)
        {
            LoadRecentData();
        }
    }
}
