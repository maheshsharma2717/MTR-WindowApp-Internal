using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using MTRDesktopApplication.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class paymentKeySquare : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
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
        public string PaymentType { get; set; }
        public string PaymentMode { get; set; }

        private List<PaymentTypesSetting> paymentSettings;
        public paymentKeySquare()
        {
            InitializeComponent();
            SetRoundButton(CloseBtn);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgnn(0, 0, Width, Height, 20, 20));
            SetRoundPanel(panel2, 5, Color.LightGray);
            SetRoundPanel(panel3, 5, Color.LightGray);
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            DeleteObject(region);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgnn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
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
        private async void paymentKeySquare_Load(object sender, EventArgs e)
        {
            string endpoint = $"api/PaymentSetting?Domainid={GlobalServices.Domainid}";
            ShowTickButtonPictureBox();
            paymentSettings = await MakeHttpGetRequest<List<PaymentTypesSetting>>(endpoint);

            var responseData = paymentSettings.FirstOrDefault(x => x.PaymentType == PaymentType);

            if (responseData != null)
            {
                if (PaymentMode == "Production")
                {
                    textBoxSecretKey.Text = responseData.SecretKey;
                    textBoxPublicKey.Text = responseData.PublicKey;
                }
                else if (PaymentMode == "Testing")
                {
                    textBoxSecretKey.Text = responseData.TestingSecretKey;
                    textBoxPublicKey.Text = responseData.TestingPublicKey;
                }
            }
            HideTickButtonPictureBox();
        }
        private bool IsValidForm()
        {
            bool isValid = true;

            labelPublicKeyError.Visible = false;
            labelSecretKeyError.Visible = false;

            if (string.IsNullOrWhiteSpace(textBoxPublicKey.Text))
            {
                labelPublicKeyError.Visible = true;
                labelPublicKeyError.Text = "Public Key is required.";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxSecretKey.Text))
            {
                labelSecretKeyError.Visible = true;
                labelSecretKeyError.Text = "Secret Key is required.";
                isValid = false;
            }
            return isValid;
        }
        private async void addKeyBtn_Click(object sender, EventArgs e)
        {
            var filteredPayment = paymentSettings.Where(x => x.PaymentType == PaymentType);
            var res = IsValidForm();
            if (res)
            {
                ShowTickButtonPictureBox();

                if (PaymentMode == "Production")
                {
                    filteredPayment.FirstOrDefault().SecretKey = textBoxSecretKey.Text;
                    filteredPayment.FirstOrDefault().PublicKey = textBoxPublicKey.Text;
                }
                else if (PaymentMode == "Testing")
                {
                    filteredPayment.FirstOrDefault().TestingSecretKey = textBoxSecretKey.Text;
                    filteredPayment.FirstOrDefault().TestingPublicKey = textBoxPublicKey.Text;
                }

                bool response = await MakeHttpPostRequest<PaymentTypesSetting>("api/PaymentSetting/AddPaymentSetting", filteredPayment, this);
                HideTickButtonPictureBox();

                ToasterMessages toaster = new ToasterMessages();
                if (response)
                {
                    toaster.ShowMessage("Key added successfully.!", MessageType.Success);
                }
                else
                {
                    toaster.ShowMessage("Failed to update Key.!", MessageType.Error);
                }
                toaster.Show();
            }
        }
        private async Task<bool> MakeHttpPostRequest<T>(string endpoint, object data, Form formToClose)
        {
            try
            {
                string url = baseUrl + endpoint;
                string jsonData = JsonConvert.SerializeObject(data);
                HttpContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                bool isSuccess = bool.Parse(responseData);
                formToClose.Close();
                return isSuccess;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
    }
}
