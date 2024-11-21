using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using MTRDesktopApplication.Enums;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Net;
using System.Runtime.InteropServices;

namespace MTRDesktopApplication
{
    public partial class Settings : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        public event EventHandler SaveComplete;//For closing popup window after saving the data.
        public Settings()
        {
            LoadDataApiKey();
            InitializeComponent();
            SetRoundButton(addPaymentBtn);
            SetRoundButton(Savebutton);
            PaymentSetting paymentSettingControl = new PaymentSetting();
            paymentSettingControl.Location = new Point(10, 10);
            this.Controls.Add(paymentSettingControl);
            SetRoundPanel(panel, 10, Color.LightGray);
            SetRoundPanel(panelapiKey, 10, Color.LightGray);
            SetRoundPanel(panelapiKeyImg, 10, Color.LightGray);
            SetRoundPanel(StripePanel, 10, Color.LightGray);
            SetRoundPanel(panelTextBox, 10, Color.LightGray);
            SetRoundPanel(panel10, 10, Color.LightGray);
            SetRoundPanel(panel1, 10, Color.LightGray);
            SetRoundPanel(panel9, 10, Color.LightGray);
            SetRoundPanel(panel5, 10, Color.LightGray);
            SetRoundPanel(panel3, 10, Color.LightGray);
            SetRoundPanel(panel6, 10, Color.LightGray);
            SetRoundPanel(panel11, 10, Color.LightGray);
            SetRoundPanel(panelSquareTesting, 5, Color.LightGray);
            SetRoundPanel(panelSquareProduction, 5, Color.LightGray);
            SetRoundPanel(panelStripeProduction, 5, Color.LightGray);
            SetRoundPanel(panelStripeTesting, 5, Color.LightGray);
            stripeProduction.CheckedChanged += stripeProduction_CheckedChanged;
            checkBoxStripeTesting.CheckedChanged += checkBoxStripeTesting_CheckedChanged;
            checkBoxSquareProduction.CheckedChanged += checkBoxSquareProduction_CheckedChanged;
            checkBoxSquareTesting.CheckedChanged += checkBoxSquareTesting_CheckedChanged;
        }
        private async Task LoadData()
        {
            try
            {
                ShowTickButtonPictureBox();
                string endpoint = $"api/PaymentSetting?Domainid={GlobalServices.Domainid}";
                List<PaymentTypesSetting> paymentSettings = await MakeHttpGetRequest<List<PaymentTypesSetting>>(endpoint);
                if (paymentSettings != null && paymentSettings.Count > 0)
                {
                    foreach (var setting in paymentSettings)
                    {
                        if (setting.PaymentType == PaymentSettingEnum.Cash)
                        {
                            enabledCheckBoxCash.Checked = setting.PaymentGateway ?? false;
                        }
                        if (setting.PaymentType == PaymentSettingEnum.Stripe)
                        {
                            stripeProduction.CheckedChanged -= stripeProduction_CheckedChanged;
                            checkBoxStripeTesting.CheckedChanged -= checkBoxStripeTesting_CheckedChanged;

                            stripeProduction.Checked = setting.ProductionMode ?? false;
                            checkBoxStripeTesting.Checked = setting.TestingMode ?? false;
                            enabledCheckBoxStripe.Checked = setting.PaymentGateway ?? false;
                            stripeProduction.CheckedChanged += stripeProduction_CheckedChanged;
                            checkBoxStripeTesting.CheckedChanged += checkBoxStripeTesting_CheckedChanged;
                        }
                        if (setting.PaymentType == PaymentSettingEnum.Square)
                        {
                            checkBoxSquareProduction.CheckedChanged -= checkBoxSquareProduction_CheckedChanged;
                            checkBoxSquareTesting.CheckedChanged -= checkBoxSquareTesting_CheckedChanged;
                            checkBoxSquareProduction.Checked = setting.ProductionMode ?? false;
                            checkBoxSquareTesting.Checked = setting.TestingMode ?? false;
                            enabledCheckBoxSquare.Checked = setting.PaymentGateway ?? false;
                            checkBoxSquareProduction.CheckedChanged += checkBoxSquareProduction_CheckedChanged;
                            checkBoxSquareTesting.CheckedChanged += checkBoxSquareTesting_CheckedChanged;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No payment settings found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                HideTickButtonPictureBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void stripeProduction_CheckedChanged(object sender, EventArgs e)
        {
            if (stripeProduction.Checked)
            {
                checkBoxStripeTesting.CheckedChanged -= checkBoxStripeTesting_CheckedChanged;
                checkBoxStripeTesting.Checked = false;
                checkBoxStripeTesting.CheckedChanged += checkBoxStripeTesting_CheckedChanged;
                enabledCheckBoxStripe.Checked = true;
                enabledLabelStripe.Text = "Enabled";
                stripeProductionKey_Click(sender, e);
            }
        }
        private void checkBoxStripeTesting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStripeTesting.Checked)
            {
                stripeProduction.CheckedChanged -= stripeProduction_CheckedChanged;
                stripeProduction.Checked = false;
                stripeProduction.CheckedChanged += stripeProduction_CheckedChanged;
                enabledCheckBoxStripe.Checked = true;
                enabledLabelStripe.Text = "Enabled";
                stripeTestingKey_Click(sender, e);
            }
        }
        private void checkBoxSquareProduction_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSquareProduction.Checked)
            {
                checkBoxSquareTesting.CheckedChanged -= checkBoxSquareTesting_CheckedChanged;
                checkBoxSquareTesting.Checked = false;
                checkBoxSquareTesting.CheckedChanged += checkBoxSquareTesting_CheckedChanged;
                enabledCheckBoxSquare.Checked = true;
                enabledLabelSquare.Text = "Enabled";
                squareProductionKey_Click(sender, e);
            }
        }
        private void checkBoxSquareTesting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSquareTesting.Checked)
            {
                checkBoxSquareProduction.CheckedChanged -= checkBoxSquareProduction_CheckedChanged;
                checkBoxSquareProduction.Checked = false;
                checkBoxSquareProduction.CheckedChanged += checkBoxSquareProduction_CheckedChanged;
                enabledCheckBoxSquare.Checked = true;
                enabledLabelSquare.Text = "Enabled";
                squareTestingKey_Click(sender, e);
            }
        }
        private void homeBreadcrumb_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
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
        private async void Payment_Load(object sender, EventArgs e)
        {
            LoadData();
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
        private async void addPaymentBtn_Click(object sender, EventArgs e)
        {
            string endpoint = $"api/PaymentSetting?Domainid={GlobalServices.Domainid}";
            List<PaymentTypesSetting> paymentSetting = await MakeHttpGetRequest<List<PaymentTypesSetting>>(endpoint);
            List<PaymentTypesSetting> paymentSettings = new List<PaymentTypesSetting>();
            ShowTickButtonPictureBox();
            PaymentTypesSetting paymentSettingCash = new PaymentTypesSetting();
            paymentSettingCash.DomainId = int.Parse(GlobalServices.Domainid);
            paymentSettingCash.PaymentType = PaymentSettingEnum.Cash;
            paymentSettingCash.PaymentGateway = enabledCheckBoxCash.Checked;
            paymentSettings.Add(paymentSettingCash);
            PaymentTypesSetting paymentSettingStripe = new PaymentTypesSetting();
            paymentSettingStripe.DomainId = int.Parse(GlobalServices.Domainid);
            paymentSettingStripe.PaymentType = PaymentSettingEnum.Stripe;
            paymentSettingStripe.ProductionMode = stripeProduction.Checked;
            paymentSettingStripe.TestingMode = checkBoxStripeTesting.Checked;
            if (stripeProduction.Checked || checkBoxStripeTesting.Checked)
            {
                paymentSettingStripe.PaymentGateway = true;
            }
            else
            {
                paymentSettingStripe.PaymentGateway = false;
            }
            if (paymentSetting != null)
            {
                var keyExistStripe = paymentSetting.Where(x => x.PaymentType == PaymentSettingEnum.Stripe).FirstOrDefault();
                if (keyExistStripe != null)
                {
                  paymentSettingStripe.TestingPublicKey = keyExistStripe.TestingPublicKey;
                  paymentSettingStripe.PublicKey = keyExistStripe.PublicKey;
                  paymentSettingStripe.SecretKey = keyExistStripe.SecretKey;
                  paymentSettingStripe.TestingSecretKey = keyExistStripe.TestingSecretKey;
                }
            }
            paymentSettings.Add(paymentSettingStripe);
            PaymentTypesSetting paymentSettingSquare = new PaymentTypesSetting();
            paymentSettingSquare.DomainId = int.Parse(GlobalServices.Domainid);
            paymentSettingSquare.PaymentType = PaymentSettingEnum.Square;
            paymentSettingSquare.ProductionMode = checkBoxSquareProduction.Checked;
            paymentSettingSquare.TestingMode = checkBoxSquareTesting.Checked;
            if (checkBoxSquareProduction.Checked || checkBoxSquareTesting.Checked)
            {
                paymentSettingSquare.PaymentGateway = true;
            }
            else
            {
                paymentSettingSquare.PaymentGateway = false;
            }
            if (paymentSetting != null)
            {
                var keyExistSquare = paymentSetting.Where(x => x.PaymentType == PaymentSettingEnum.Square).FirstOrDefault();
                if (keyExistSquare != null)
                {
                    paymentSettingSquare.TestingPublicKey = keyExistSquare.TestingPublicKey;
                    paymentSettingSquare.PublicKey = keyExistSquare.PublicKey;
                    paymentSettingSquare.SecretKey = keyExistSquare.SecretKey;
                    paymentSettingSquare.TestingSecretKey = keyExistSquare.TestingSecretKey;
                }
            }
            paymentSettings.Add(paymentSettingSquare);
            ToasterMessages toaster = new ToasterMessages();
            bool response = await MakeHttpPostRequest<PaymentTypesSetting>("api/PaymentSetting/AddPaymentSetting", paymentSettings);
            HideTickButtonPictureBox();
            if (response)
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
                toaster.ShowMessage("Failed to update payment settings.!", MessageType.Error);
                toaster.Show();
            }
        }
        private async Task<bool> MakeHttpPostRequest<T>(string endpoint, object data)
        {
            string url = baseUrl + endpoint;
            string jsonData = JsonConvert.SerializeObject(data);
            HttpContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            bool isSuccess = bool.Parse(responseData);
            return isSuccess;
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
        private void stripeProductionKey_Click(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            Form formBackground = new Form();
            paymentKeySquare payment = new paymentKeySquare();
            payment.labelProduction.Text = labelStripeProduction.Text;
            payment.paymentType.Text = "Stripe";
            payment.pictureBox.Image = Properties.Resources.stripePayment;
            payment.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            payment.PaymentType = "Stripe";
            payment.PaymentMode = "Production";
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = .50d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.Show();
            payment.Owner = formBackground;
            payment.ShowDialog();
            formBackground.Dispose();
            HideTickButtonPictureBox();
        }
        private void stripeTestingKey_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            paymentKeySquare payment = new paymentKeySquare();
            payment.labelProduction.Text = labelStripeTestig.Text;
            payment.paymentType.Text = "Stripe";
            payment.pictureBox.Image = Properties.Resources.stripePayment;
            payment.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            payment.PaymentType = "Stripe";
            payment.PaymentMode = "Testing";
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = .50d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.Show();
            payment.Owner = formBackground;
            payment.ShowDialog();
            formBackground.Dispose();
        }
        private void squareProductionKey_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            paymentKeySquare payment = new paymentKeySquare();
            payment.labelProduction.Text = labelSquareProduction.Text;
            payment.paymentType.Text = "Square";
            payment.PaymentType = "Square";
            payment.PaymentMode = "Production";
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = .50d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.Show();
            payment.Owner = formBackground;
            payment.ShowDialog();
            formBackground.Dispose();
        }
        private void squareTestingKey_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            paymentKeySquare payment = new paymentKeySquare();
            payment.labelProduction.Text = labelSquareTesting.Text;
            payment.paymentType.Text = "Square";
            payment.PaymentType = "Square";
            payment.PaymentMode = "Testing";
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = .50d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Maximized;
            formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.Show();
            payment.Owner = formBackground;
            payment.ShowDialog();
            formBackground.Dispose();
        }
        private void enabledCheckBoxStripe_CheckedChanged(object sender, EventArgs e)
        {
            if (!enabledCheckBoxStripe.Checked)
            {
                stripeProduction.Checked = false;

                checkBoxStripeTesting.Checked = false;
                enabledLabelStripe.Text = "Disabled";
            }
            else
            {
                enabledLabelStripe.Text = "Enabled";
            }
        }
        private void enabledCheckBoxSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (!enabledCheckBoxSquare.Checked)
            {
                checkBoxSquareProduction.Checked = false;
                checkBoxSquareTesting.Checked = false;
                enabledLabelSquare.Text = "Disabled";
            }
            else
            {
                enabledLabelSquare.Text = "Enabled";
            }
        }

        private void enabledCheckBoxCash_CheckedChanged(object sender, EventArgs e)
        {
            if (enabledCheckBoxCash.Checked)
            {
                enabledLabelCash.Text = "Enabled";
            }
            else
            {
                enabledLabelCash.Text = "Disabled";
            }
        }

        /// <summary>
        /// new tab google api
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private async void Savebutton_Click(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            ApiKeys newApiKey = new ApiKeys
            {
                ApiKey = textBoxApiKey.Text,
                DomainId = int.Parse(GlobalServices.Domainid)
            };

            bool response = await MakeHttpPostRequest<ApiKeys>("api/ApiKeys/AddApiKeys", newApiKey);
            HideTickButtonPictureBox();
            if (response)
            {
                textBoxApiKey.Clear();
                await LoadData();
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
                MessageBox.Show("Failed to save API key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HideTickButtonPictureBox();
        }
        private async Task LoadDataApiKey()
        {
            string endpoint = $"api/ApiKeys?Domainid={GlobalServices.Domainid}";
            try
            {
                var apiKeysList = await MakeHttpGetRequestApi<ApiKeys>(endpoint);
                if (apiKeysList != null && !string.IsNullOrEmpty(apiKeysList.ApiKey))
                {
                    textBoxApiKey.Text = apiKeysList.ApiKey;
                }
                else
                {
                    textBoxApiKey.Text = "API key not found.";
                }
            }
            catch (Exception ex)
            {
                textBoxApiKey.Text = $"Error: {ex.Message}";
            }
        }
        private async Task<T> MakeHttpGetRequestApi<T>(string endpoint)
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
