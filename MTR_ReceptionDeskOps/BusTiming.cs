using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using MTRDesktopApplication.Properties;
using Newtonsoft.Json;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace MTRDesktopApplication
{
    public partial class BusTiming : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 0;
        public BusTiming()
        {
            InitializeComponent();
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            SetRoundButton(AddBusTiming);
            SetRoundPanel(BackBtn, 20, System.Drawing.Color.LightGray);
            SetRoundPanel(NextBtn, 20, System.Drawing.Color.LightGray);
            busById.Visible = false;
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
            IntPtr region = CreateRoundRectRgnn(0, 0, panel.Width + 1, panel.Height + 1, diameter, diameter);
            panel.Region = Region.FromHrgn(region);
            DeleteObjectt(region);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgnn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObjectt(IntPtr hObject);
        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "colour")
                {
                    Color rowBackgroundColor = (e.State & DataGridViewElementStates.Selected) != 0
                        ? dataGridView1.DefaultCellStyle.SelectionBackColor
                        : (e.RowIndex % 2 == 0
                            ? dataGridView1.DefaultCellStyle.BackColor
                            : dataGridView1.AlternatingRowsDefaultCellStyle.BackColor);
                    using (Brush backColorBrush = new SolidBrush(rowBackgroundColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                    }
                    e.Paint(e.CellBounds, DataGridViewPaintParts.Border);
                    string colorString = e.Value as string;
                    if (!string.IsNullOrEmpty(colorString))
                    {
                        Color cellColor;
                        try
                        {
                            cellColor = ColorTranslator.FromHtml(colorString);
                        }
                        catch (Exception)
                        {
                            cellColor = Color.White;
                        }
                        int desiredWidth = 30;
                        int desiredHeight = 30;
                        int x = e.CellBounds.X + (e.CellBounds.Width - desiredWidth) / 2;
                        int y = e.CellBounds.Y + (e.CellBounds.Height - desiredHeight) / 2;
                        int cornerRadius = 30;
                        using (GraphicsPath path = new GraphicsPath())
                        {
                            path.AddArc(x, y, cornerRadius, cornerRadius, 180, 90);
                            path.AddArc(x + desiredWidth - cornerRadius, y, cornerRadius, cornerRadius, 270, 90);
                            path.AddArc(x + desiredWidth - cornerRadius, y + desiredHeight - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                            path.AddArc(x, y + desiredHeight - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                            path.CloseAllFigures();
                            using (Brush brush = new SolidBrush(cellColor))
                            {
                                e.Graphics.FillPath(brush, path);
                            }
                        }
                        e.Handled = true;
                    }
                }
            }
        }
        private async void BusTiming_Load(object sender, EventArgs e)
        {
            LoadData(currentPage);
            UpdatePaginationLabel();
            InitializeDataGridView();
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
        private void InitializeDataGridView()
        {
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["viewMore"].Index)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "View More";
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen.BusTimingDetailForm(id);
            }
        }
        private async Task LoadData(int page)
        {
            try
            {
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                string endpoint = $"api/BusTiming?pageNumber={page}&pageSize={pageSize}&Domainid={GlobalServices.Domainid}";
                ShowTickButtonPictureBox();
                List<BusTimingDto> busTimings = await MakeHttpGetRequest<List<BusTimingDto>>(endpoint);
                if (busTimings != null)
                {
                    int startingIndex = (page - 1) * pageSize + 1;
                    dataGridView1.Rows.Clear();
                    foreach (var busTiming in busTimings)
                    {
                        string departureTime = busTiming.DepartureTime.HasValue ? busTiming.DepartureTime.Value.ToString("h:mm tt") : "";
                        string arrivalTime = busTiming.ArrivalTime.HasValue ? busTiming.ArrivalTime.Value.ToString("h:mm tt") : "";
                        object[] rowData =
                        {
                            startingIndex,
                            imageList1.Images.Count > 0 ? imageList1.Images[0] : null,
                            busTiming.Model,
                            busTiming.PlateNumber,
                            busTiming.Color,
                            busTiming.Color,
                            busTiming.NumberOfSeatsAvailable,
                            busTiming.SeatingPlan,
                            departureTime,
                            arrivalTime,
                            busTiming.BusTimingId,
                        };
                        dataGridView1.Rows.Add(rowData);
                        startingIndex++;
                    }
                    dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridView1.CellFormatting += DataGridView1_CellFormatting;
                    dataGridView1.Refresh();
                    int totalRecords = await GetTotalRecordCount();
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    UpdatePaginationLabel();
                }
                else
                {
                    MessageBox.Show("Failed to load data.OR No data in data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HideTickButtonPictureBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["colour"].Index && e.RowIndex >= 0)
            {
                var colorString = e.Value as string;
                if (!string.IsNullOrEmpty(colorString))
                {
                    colorString = colorString.Trim();
                    if (colorString.Length == 8 && IsHexadecimal(colorString.Substring(0, 6)))
                    {
                        try
                        {
                            Color backColor = ColorTranslator.FromHtml("#" + colorString.Substring(0, 6));
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = backColor;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Invalid color format: " + ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            Color cellColor = ColorTranslator.FromHtml(colorString);
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = cellColor;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Invalid color format: " + ex.Message);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Color string is null or empty.");
                }
            }
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
        private async Task<int> GetTotalRecordCount()
        {
            try
            {
                string endpoint = $"api/BusTiming/GetBusTimingCount";
                return await MakeHttpGetRequest<int>(endpoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total record count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
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
        private void AddBusTiming_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = 0.50d;
            formBackground.BackColor = System.Drawing.Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            AddBusTiming addBustiming = new AddBusTiming();
            addBustiming.Owner = formBackground;
            //formBackground.Show();
            addBustiming.ShowDialog();
            formBackground.SendToBack();
            formBackground.Dispose();
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
            else
            {
                MessageBox.Show("You are already on the last page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("You are already on the first page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void HomebreadCrumb_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
        }
    }
}