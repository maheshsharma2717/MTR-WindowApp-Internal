using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class HotelId : Form
    {
        private List<string> hotelIds;
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private List<string> existingHotelIds;
        private int currentPage = 1;
        private const int pageSize = 24;
        private readonly HttpClient httpClient = new HttpClient();

        public string SelectedHotelId { get; private set; }

        public HotelId()
        {
            InitializeComponent();
            Load += async (sender, e) =>
            {
                existingHotelIds = await FetchExistingHotelIdsAsync();
                GenerateHotelIds();
                DisplayPage(currentPage);
            };
            SetRoundButton(Savebutton);
            SetRoundPanel(btnNext, 10,Color.LightGray);
            SetRoundPanel(btnPrevious, 10,Color.LightGray);
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
            //button.FlatAppearance.BorderColor = Color.Black;
           // button.FlatAppearance.BorderSize = borderWidth;
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

        private async Task<List<string>> FetchExistingHotelIdsAsync()
        {
            string endpoint = $"api/Hotel/GetAllHotelNumbers?domainId={GlobalServices.Domainid}";
            List<string> existingHotelIds = await MakeHttpGetRequest<List<string>>(endpoint);
            return existingHotelIds ?? new List<string>();
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

        //private void GenerateHotelIds()
        //{
        //    hotelIds = new List<string>();
        //    for (int i = 1; i <= 999; i++)
        //    {
        //        string hotelId = $"H{i:D3}";
        //        if (!existingHotelIds.Contains(hotelId))
        //        {
        //            hotelIds.Add(hotelId);
        //        }
        //    }
        //}
        private void GenerateHotelIds()
        {
            hotelIds = new List<string>();
            for (int i = 1; i <= 999; i++)
            {
                string hotelId = $"H{i:D3}";
                if (!existingHotelIds.Contains(hotelId))
                {
                    hotelIds.Add(hotelId);
                }
            }
        }
        //private void DisplayPage(int page)
        //{
        //    flowLayoutPanel1.Controls.Clear();

        //    int startIndex = (page - 1) * pageSize;
        //    int endIndex = Math.Min(startIndex + pageSize, hotelIds.Count);

        //    for (int i = startIndex; i < endIndex; i++)
        //    {
        //        CheckBox checkBox = new CheckBox
        //        {
        //            Text = hotelIds[i],
        //            AutoSize = true,
        //    Font = new Font("Inter SemiBold", 9, FontStyle.Regular)
        //        };
        //        checkBox.CheckedChanged += CheckBox_CheckedChanged;
        //        flowLayoutPanel1.Controls.Add(checkBox);
        //    }

        //    lblPageNumber.Text = $"Page {currentPage}";
        //}
        private void DisplayPage(int page)
        {
            flowLayoutPanel1.Controls.Clear();

            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, hotelIds.Count);
            const int checkBoxWidth = 100;
            const int checkBoxHeight = 30;
            Padding checkBoxPadding = new Padding(5);
            foreach (string hotelId in hotelIds.Skip(startIndex).Take(endIndex - startIndex))
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = hotelId,
                    AutoSize = false,  
                    Width = checkBoxWidth, 
                    Height = checkBoxHeight, 
                    Font = new Font("Inter SemiBold", 9, FontStyle.Regular),
                    Padding = checkBoxPadding,
                    Margin = checkBoxPadding,
                    TextAlign = ContentAlignment.MiddleCenter 
                };
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                flowLayoutPanel1.Controls.Add(checkBox);
            }

            lblPageNumber.Text = $"Page {currentPage}";
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                foreach (var control in flowLayoutPanel1.Controls)
                {
                    if (control is CheckBox checkBox && checkBox != sender)
                    {
                        checkBox.Checked = false;
                    }
                }

                SelectedHotelId = ((CheckBox)sender).Text;
            }
        }
        //private void CheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (((CheckBox)sender).Checked)
        //    {
        //        foreach (var control in flowLayoutPanel1.Controls)
        //        {
        //            if (control is CheckBox checkBox && checkBox != sender)
        //            {
        //                checkBox.Checked = false;
        //            }
        //        }

        //        SelectedHotelId = ((CheckBox)sender).Text;
        //    }
        //}

        private void Savebutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayPage(currentPage);
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (currentPage * pageSize < hotelIds.Count)
            {
                currentPage++;
                DisplayPage(currentPage);
            }
        }
    }
}
