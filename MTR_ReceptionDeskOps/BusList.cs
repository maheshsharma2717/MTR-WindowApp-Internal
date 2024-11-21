using Newtonsoft.Json;
using Domain.gettaxiusa.com.Entities;
using System.Configuration;
using MTRDesktopApplication.Dtos;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
namespace MTRDesktopApplication
{
    public partial class BusList : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 0;
        public BusList()
        {
            InitializeComponent();
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            SetRoundButton(addBusButton);
            SetRoundPanel(BackBtn, 20, System.Drawing.Color.LightGray);
            SetRoundPanel(NextBtn, 20, System.Drawing.Color.LightGray);
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

        private void BusList_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            LoadData(currentPage);
            UpdatePaginationLabel();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }
        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Colour")
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

        private async Task LoadData(int page)
        {
            string endpoint = $"api/Vehicle?pageNumber={page}&pageSize={pageSize}&Domainid={GlobalServices.Domainid}";
            ShowTickButtonPictureBox();

            List<Vehicles> vehicles = await MakeHttpGetRequest<List<Vehicles>>(endpoint);

            if (vehicles != null)
            {
                dataGridView1.SuspendLayout();
                dataGridView1.Rows.Clear();

                int startingIndex = (page - 1) * pageSize + 1;

                foreach (var vehicle in vehicles)
                {
                    var status = vehicle.IsActive == true ? Properties.Resources.active : Properties.Resources.pending;
                    dataGridView1.Rows.Add(new object[]
                    {
                      startingIndex++,
                      vehicle.VehicleId,
                      modelBusList.Images[0],
                      vehicle.VehicleName,
                      vehicle.PlateNumber,
                      vehicle.VehicleColor,
                      vehicle.VehicleColor,
                      vehicle.NumberOfSeatsAvailable,
                      vehicle.SeatingPlan,
                      vehicle.Destination,
                      status,
                    });
                }
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.ResumeLayout();
            }
            else
            {
                MessageBox.Show("Failed to load data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HideTickButtonPictureBox();
            totalPages = (int)Math.Ceiling((double)await GetTotalRecordCount() / pageSize);
            UpdatePaginationLabel();
        }

        private async Task<int> GetTotalRecordCount()
        {
            string endpoint = "api/Vehicle/GetVehiclesCount";
            try
            {
                return await MakeHttpGetRequest<int>(endpoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total record count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return default;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Viewmore1"].Index)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen.BusDetailForm(id);
            }
        }
        private void UpdatePaginationLabel()
        {
            PaginationLbl.Text = $"Page {currentPage} of {totalPages}";
        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(currentPage);
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(currentPage);
            }
        }
        private void addBusButton_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            AddBusForm popup = new AddBusForm();
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = .50d;
            formBackground.BackColor = System.Drawing.Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
           // formBackground.Show();
            popup.Owner = formBackground;
            popup.ShowDialog();
            formBackground.Dispose();
        }
        private void homeBreadcrumbs_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                if (e.RowIndex == 5)
                {
                    e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                    using (var path = new GraphicsPath())
                    {
                        Rectangle bounds = e.CellBounds;
                        bounds.Inflate(-2, -2);
                        int cornerRadius = 20;
                        path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
                        path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
                        path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                        path.AddArc(bounds.X, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                        path.CloseFigure();
                        e.Graphics.SetClip(path);
                        e.PaintContent(e.ClipBounds);
                        e.Graphics.ResetClip();
                    }
                    e.Handled = true;
                }
            }
        }
    }
}
