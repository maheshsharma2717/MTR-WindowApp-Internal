using CountryFlag;
using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;
namespace MTRDesktopApplication
{
    public partial class AddHotelForm : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private Dictionary<string, Image> countryFlags = new Dictionary<string, Image>();
        private string _imagePath = string.Empty;
        public long _hotelID = 0;
        public List<Vehicles> _vehicle = new List<Vehicles>();
        public string addressOldName = string.Empty;
        private string googleMapsApiKey;
        public event EventHandler SaveComplete;//For closing popup window after saving the data .
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

        public AddHotelForm()
        {
            InitializeComponent();
            comboBoxCountry.DropDownHeight = 100;
            comboBoxCountry.DropDownWidth = 90;
            SetRoundButton(Savebutton);
            SetRoundButton(UploadBtn);
            SetRoundPanel(panel3, 5, Color.LightGray);
            SetRoundPanel(panel4, 5, Color.LightGray);
            SetRoundPanel(panel5, 5, Color.LightGray);
            SetRoundPanel(panel6, 5, Color.LightGray);
            SetRoundPanel(panel7, 5, Color.LightGray);
            SetRoundPictureBox(hotelpictureBox, Color.Transparent);
            SetRoundPictureBox(pictureBoxCountry, Color.Transparent);
            this.AutoScroll = true;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            countryFlags.Add("+1", Properties.Resources.UnitedStates);
            countryFlags.Add("+7", Properties.Resources.Russia);
            countryFlags.Add("+30", Properties.Resources.Greece);
            countryFlags.Add("+31", Properties.Resources.Netherlands);
            countryFlags.Add("+32", Properties.Resources.Belgium);
            countryFlags.Add("+33", Properties.Resources.France);
            countryFlags.Add("+34", Properties.Resources.Spain);
            countryFlags.Add("+36", Properties.Resources.Hungary);
            countryFlags.Add("+39", Properties.Resources.Italy);
            countryFlags.Add("+40", Properties.Resources.Romania);
            countryFlags.Add("+41", Properties.Resources.Switzerland);
            countryFlags.Add("+43", Properties.Resources.Austria);
            countryFlags.Add("+44", Properties.Resources.UnitedKingdom);
            countryFlags.Add("+45", Properties.Resources.Denmark);
            countryFlags.Add("+46", Properties.Resources.Sweden);
            countryFlags.Add("+47", Properties.Resources.Norway);
            countryFlags.Add("+48", Properties.Resources.Poland);
            countryFlags.Add("+49", Properties.Resources.Germany);
            countryFlags.Add("+55", Properties.Resources.Brazil);
            countryFlags.Add("+57", Properties.Resources.Colombia);
            countryFlags.Add("+61", Properties.Resources.Australia);
            countryFlags.Add("+90", Properties.Resources.Turkey);
            countryFlags.Add("+91", Properties.Resources.India);
            countryFlags.Add("+92", Properties.Resources.pakistan);
            countryFlags.Add("+98", Properties.Resources.Iran);
            countryFlags.Add("+351", Properties.Resources.Portugal);
            countryFlags.Add("+352", Properties.Resources.Luxembourg);
            countryFlags.Add("+353", Properties.Resources.Ireland);
            countryFlags.Add("+354", Properties.Resources.Iceland);
            countryFlags.Add("+355", Properties.Resources.Albania);
            countryFlags.Add("+356", Properties.Resources.Malta);
            countryFlags.Add("+357", Properties.Resources.Cyprus);
            countryFlags.Add("+358", Properties.Resources.Finland);
            countryFlags.Add("+359", Properties.Resources.Bulgaria);
            countryFlags.Add("+370", Properties.Resources.Lithuania);
            countryFlags.Add("+371", Properties.Resources.Latvia);
            countryFlags.Add("+372", Properties.Resources.Estonia);
            countryFlags.Add("+373", Properties.Resources.Moldova);
            countryFlags.Add("+374", Properties.Resources.Armenia);
            countryFlags.Add("+375", Properties.Resources.Belarus);
            countryFlags.Add("+376", Properties.Resources.Andorra);
            countryFlags.Add("+377", Properties.Resources.Monaco);
            countryFlags.Add("+378", Properties.Resources.SanMarino);
            countryFlags.Add("+380", Properties.Resources.Ukraine);
            countryFlags.Add("+381", Properties.Resources.Serbia);
            countryFlags.Add("+382", Properties.Resources.Montenegro);
            countryFlags.Add("+383", Properties.Resources.Kosovo);
            countryFlags.Add("+385", Properties.Resources.Croatia);
            countryFlags.Add("+386", Properties.Resources.Slovenia);
            countryFlags.Add("+387", Properties.Resources.BosniaAndHerzegovina);
            countryFlags.Add("+389", Properties.Resources.NorthMacedonia);
            countryFlags.Add("+420", Properties.Resources.CzechRepublic);
            countryFlags.Add("+421", Properties.Resources.Slovakia);
            countryFlags.Add("+423", Properties.Resources.Liechtenstein);
            countryFlags.Add("+880", Properties.Resources.Bangladesh);
            countryFlags.Add("+964", Properties.Resources.Iraq);
            countryFlags.Add("+994", Properties.Resources.Azerbaijan);
            countryFlags.Add("+995", Properties.Resources.Georgia);
            countryFlags.Add("+213", Properties.Resources.Algeria);
            countryFlags.Add("+226", Properties.Resources.BurkinaFaso);
            countryFlags.Add("+237", Properties.Resources.Cameroon);
            countryFlags.Add("+242", Properties.Resources.CongoRepublic);
            countryFlags.Add("+243", Properties.Resources.CongoDemocratic);
            countryFlags.Add("+225", Properties.Resources.CotedIvoire);
            countryFlags.Add("+509", Properties.Resources.Haiti);
            countryFlags.Add("+62", Properties.Resources.Indonesia);
            countryFlags.Add("+972", Properties.Resources.Israel);
            countryFlags.Add("+81", Properties.Resources.Japan);
            countryFlags.Add("+254", Properties.Resources.Kenya);
            countryFlags.Add("+82", Properties.Resources.SouthKorea);
            countryFlags.Add("+218", Properties.Resources.Libya);
            countryFlags.Add("+261", Properties.Resources.Madagascar);
            countryFlags.Add("+60", Properties.Resources.Malaysia);
            countryFlags.Add("+234", Properties.Resources.Nigeria);
            countryFlags.Add("+63", Properties.Resources.Philippines);
            countryFlags.Add("+974", Properties.Resources.Qatar);
            countryFlags.Add("+966", Properties.Resources.SaudiArabia);
            countryFlags.Add("+221", Properties.Resources.Senegal);
            countryFlags.Add("+27", Properties.Resources.SouthAfrica);
            countryFlags.Add("+94", Properties.Resources.SriLanka);
            countryFlags.Add("+255", Properties.Resources.Tanzania);
            countryFlags.Add("+216", Properties.Resources.Tunisia);
            countryFlags.Add("+256", Properties.Resources.Uganda);
            countryFlags.Add("+971", Properties.Resources.UAE);
            countryFlags.Add("+84", Properties.Resources.Vietnam);
            countryFlags.Add("+260", Properties.Resources.Zambia);
            countryFlags.Add("+263", Properties.Resources.Zimbabwe);
            foreach (string countryCode in countryFlags.Keys)
            {
                comboBoxCountry.Items.Add(countryCode);
            }
        }
        private void UploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                hotelpictureBox.Image = new Bitmap(opnfd.FileName);
                _imagePath = opnfd.FileName;
            }
        }
        public string ImageToBase64(string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException("Image file not found.", imagePath);
            }
            Image image = Image.FromFile(imagePath);
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
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
        private void SetRoundPictureBox(PictureBox pictureBox, Color borderColor)
        {
            int radius = Math.Min(pictureBox.Width, pictureBox.Height) / 2;
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
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(borderColor, 1))
                {
                    Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                    DrawRoundedRectangle(g, pen, rect, radius);
                }
            };
        }
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
        private async void Savebutton_Click(object sender, EventArgs e)
        {
            string endpoint = $"api/Hotel/getAll?Domainid={GlobalServices.Domainid}";
            var hotels = await MakeHttpGetRequest<List<Hotels>>(endpoint);

            if (hotels == null)
            {
                MessageBox.Show("Failed to retrieve existing hotels.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = isFormvalid(hotels);
            if (result)
            {
                ShowTickButtonPictureBox();
                var countryCode = comboBoxCountry.Text.Trim();
                var phoneNumber = PhonetextBox.Text.Trim();
                Hotels newHotel = new Hotels();
                newHotel.HotelNumber = HotelnumbertextBox.Text;
                newHotel.Email = EmailtextBox.Text.Trim();
                newHotel.HotelName = HotelnametextBox.Text.Trim();
                newHotel.ContactNo = PhonetextBox.Text;
                newHotel.CountryCode = comboBoxCountry.Text;
                newHotel.Address = AddresstextBox.Text.Trim();
                newHotel.HotelPicture = !string.IsNullOrWhiteSpace(_imagePath) ? ImageToBase64(_imagePath) : string.Empty;
                newHotel.HotelId = int.Parse(_hotelID.ToString());
                newHotel.DomainId = GlobalServices.Domainid;
                //newHotel.PlateNumber = GetSelectedPlateNumber();

                bool response = await MakeHttpPostRequest<Hotels>("api/Hotel/AddHotel", newHotel);
                HideTickButtonPictureBox();
                SaveComplete?.Invoke(this, EventArgs.Empty);
                this.Close();

                ToasterMessages toaster = new ToasterMessages();
                if (response && _hotelID == 0)
                {
                    ShowSuccessPopup();
                }
                else if (response && _hotelID > 0)
                {
                    ShowSuccessPopup();
                }
                else
                {
                    toaster.ShowMessage("Failed to update Hotel information.!", MessageType.Error);
                    toaster.Show();
                }
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen.HotelListScreen();
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
        private void ShowApiKeyError()
        {
            ToasterMessages toaster = new ToasterMessages();
            toaster.ShowMessage("Google Maps API key not found. Please go to the Settings Api Key Map and save the API key there.", MessageType.Error);
            toaster.Show();
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen?.BusRouteScreen();
        }
        private async void AddHotelForm_Load_1(object sender, EventArgs e)
        {
            //if (_hotelID == null || _hotelID == 0)
            //{
            //    await InitializeDropDown();
            //}
            var apiKeyResponse = await MakeHttpGetRequest<ApiKeys>($"api/ApiKeys?domainId={GlobalServices.Domainid}");
            // InitializeDropDown();
            if (apiKeyResponse != null && !string.IsNullOrEmpty(apiKeyResponse.ApiKey))
            {
                googleMapsApiKey = apiKeyResponse.ApiKey;
            }
            else
            {
                ShowApiKeyError();
                return;
            }
            // comboBoxCountry.SelectedItem = "+1";
            HotelnametextBox.Leave += TextBox_Leave;
            EmailtextBox.Leave += TextBox_Leave;
            AddresstextBox.Leave += TextBox_Leave;
            PhonetextBox.Leave += TextBox_Leave;
            EmailtextBox.KeyUp += TextBox_KeyUp;
        }
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateField(sender as Control);
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            ValidateField(sender as Control);
        }
        private void ValidateField(Control control)
        {
            switch (control.Name)
            {
                case "HotelnametextBox":
                    ValidateHotelName();
                    break;
                case "EmailtextBox":
                    ValidateEmail();
                    break;
                case "AddresstextBox":
                    ValidateAddress();
                    break;
                default:
                    break;
            }
        }
        private void ValidateHotelName()
        {
            if (string.IsNullOrWhiteSpace(HotelnametextBox.Text))
            {
                labelHotelNameError.Visible = true;
                labelHotelNameError.Text = "Hotel name can't be empty";
            }
            else if (HotelnametextBox.Text.Length < 3 || HotelnametextBox.Text.Length > 50)
            {
                labelHotelNameError.Visible = true;
                labelHotelNameError.Text = "Hotel name must be between 3 and 50 characters";
            }
            else
            {
                labelHotelNameError.Visible = false;
            }
        }
        private void ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                labelHotelEmailError.Visible = true;
                labelHotelEmailError.Text = "Email can't be empty";
            }
            else if (!IsValidEmail(EmailtextBox.Text))
            {
                labelHotelEmailError.Visible = true;
                labelHotelEmailError.Text = "Invalid email format.  Example: user@example.com";
            }
            else
            {
                labelHotelEmailError.Visible = false;
            }
        }
        private void ValidateAddress()
        {
            if (string.IsNullOrWhiteSpace(AddresstextBox.Text))
            {
                labelHotelAddressError.Visible = true;
                labelHotelAddressError.Text = "Hotel address can't be empty";
            }
            else
            {
                labelHotelAddressError.Visible = false;
            }
        }
        private bool isFormvalid(List<Hotels> existingHotels)
        {
            string phoneNumber = PhonetextBox.Text;
            string selectedCountry = comboBoxCountry.Text;
            bool isValid = true;
            labelHotelNumberError.Visible = false;
            labelHotelNameError.Visible = false;
            labelHotelEmailError.Visible = false;
            labelHotelAddressError.Visible = false;
            labelHotelPhoneError.Visible = false;
            labelHotelPictureError.Visible = false;
            if (string.IsNullOrWhiteSpace(HotelnumbertextBox.Text))
            {
                labelHotelNumberError.Visible = true;
                labelHotelNumberError.Text = "Hotel number can't be empty";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(HotelnametextBox.Text))
            {
                labelHotelNameError.Visible = true;
                labelHotelNameError.Text = "Hotel name can't be empty";
                isValid = false;
            }
            else if (HotelnametextBox.Text.Length < 3 || HotelnametextBox.Text.Length > 50)
            {
                labelHotelNameError.Visible = true;
                labelHotelNameError.Text = "Hotel name must be between 3 and 50 characters";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                labelHotelEmailError.Visible = true;
                labelHotelEmailError.Text = "Email can't be empty";
                isValid = false;
            }
            else if (!IsValidEmail(EmailtextBox.Text))
            {
                labelHotelEmailError.Visible = true;
                labelHotelEmailError.Text = "Invalid email format. Example: user@example.com";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(AddresstextBox.Text))
            {
                labelHotelAddressError.Visible = true;
                labelHotelAddressError.Text = "Hotel address can't be empty";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                labelHotelPhoneError.Visible = true;
                labelHotelPhoneError.Text = "Phone number can't be empty";
                isValid = false;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(selectedCountry))
                {
                    labelHotelPhoneError.Visible = true;
                    labelHotelPhoneError.Text = "Country selection is required";
                    isValid = false;
                }
                else if (!countryPhoneMasks.ContainsKey(selectedCountry))
                {
                    labelHotelPhoneError.Visible = true;
                    labelHotelPhoneError.Text = "Invalid country code selected";
                    isValid = false;
                }
                else
                {
                    string mask = countryPhoneMasks[selectedCountry];
                    string numericPhoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());
                    int maskDigitCount = mask.Count(c => c == '0');
                    if (numericPhoneNumber.Length == maskDigitCount)
                    {
                        labelHotelPhoneError.Visible = false;
                    }
                    else
                    {
                        labelHotelPhoneError.Visible = true;
                        labelHotelPhoneError.Text = "Invalid phone number format";
                        isValid = false;
                    }
                }
            }

            if (hotelpictureBox.Image == null)
            {
                labelHotelPictureError.Visible = true;
                labelHotelPictureError.Text = "Picture box can't be empty";
                isValid = false;
            }
            return isValid;
        }
        private void ShowSuccessPopup()
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
                Success popup = new Success
                {
                    Owner = formBackground
                };
                popup.ShowDialog();
            }
        }
        private bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
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
        private void UpdateImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                hotelpictureBox.Image = image;
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async void loadHotelData(Hotels hotelInfo, string? name)
        {
            if (name == "Edit")
            {
                Heading.Visible = true;
            }
            _hotelID = hotelInfo.HotelId;
            await InitializeDropDown();
            HotelnametextBox.Text = hotelInfo.HotelName;
            HotelnumbertextBox.Text = hotelInfo.HotelNumber;
            EmailtextBox.Text = hotelInfo.Email;
            comboBoxCountry.Text = hotelInfo.CountryCode;
            //  comboBoxNumberPlate.Text = hotelInfo.PlateNumber;
            var cellPhone = hotelInfo.ContactNo.Split('(');
            if (cellPhone.Length == 2)
            {
                comboBoxCountry.Text = !string.IsNullOrWhiteSpace(cellPhone[0]) ? cellPhone[0] : "+1";
                PhonetextBox.Text = "(" + cellPhone[1];
            }
            else
            {
                PhonetextBox.Text = "(" + cellPhone[0];
            }
            AddresstextBox.Text = hotelInfo.Address;
            if (!string.IsNullOrWhiteSpace(hotelInfo.HotelPicture))
            {
                UpdateImage(hotelInfo.HotelPicture);
            }
        }
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = comboBoxCountry.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCountry))
            {
                if (countryFlags.ContainsKey(selectedCountry))
                {
                    pictureBoxCountry.Image = countryFlags[selectedCountry];
                }
                if (countryPhoneMasks.ContainsKey(selectedCountry))
                {
                    PhonetextBox.Mask = countryPhoneMasks[selectedCountry];
                }
            }
        }

        private void comboBoxCountry_TextChanged(object sender, EventArgs e)
        {
            string typedCode = comboBoxCountry.Text;
            if (countryFlags.ContainsKey(typedCode))
            {
                pictureBoxCountry.Image = countryFlags[typedCode];
            }
            if (countryPhoneMasks.ContainsKey(typedCode))
            {
                PhonetextBox.Mask = countryPhoneMasks[typedCode];
            }

        }

        private void PhonetextBox_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                PhonetextBox.SelectionStart = 0;
            }));
        }

        private void PhonetextBox_Click(object sender, EventArgs e)
        {
            if (PhonetextBox.SelectionStart == 0)
            {
                BeginInvoke(new Action(() =>
                {
                    PhonetextBox.SelectionStart = 0;
                }));
            }
        }

        private void changeHotelId_Click(object sender, EventArgs e)
        {
            using (HotelId popup = new HotelId())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    HotelnumbertextBox.Text = popup.SelectedHotelId;
                }
            }
        }

        private string ToTitleCase(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }
        private void HotelnametextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int selectionStart = textBox.SelectionStart;
                int selectionLength = textBox.SelectionLength;

                textBox.Text = ToTitleCase(textBox.Text);

                textBox.SelectionStart = selectionStart;
                textBox.SelectionLength = selectionLength;
            }
        }

        private void AddresstextBox_TextChanged(object sender, EventArgs e)
        {
            //TextBox textBox = sender as TextBox;
            //if (textBox != null)
            //{
            //    int selectionStart = textBox.SelectionStart;
            //    int selectionLength = textBox.SelectionLength;

            //    textBox.Text = ToTitleCase(textBox.Text);

            //    textBox.SelectionStart = selectionStart;
            //    textBox.SelectionLength = selectionLength;

            //}
            if (AddresstextBox.Text != addressOldName)
            {
                string input = AddresstextBox.Text.Trim();
                GetLocationSuggestions(input, AddressSuggestionsListBox);
                AddressSuggestionsListBox.Visible = true;
            }
        }

        private void AddressSuggestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddressSuggestionsListBox.SelectedItem != null)
            {
                string selectedName = AddressSuggestionsListBox.SelectedItem.ToString();
                addressOldName = selectedName;
                AddressSuggestionsListBox.Visible = false;
                AddresstextBox.Text = selectedName;
                AddressSuggestionsListBox.SelectedIndex = -1;
            }
        }
        private void AddressSuggestionsListBox_Click(object sender, EventArgs e)
        {
            AddressSuggestionsListBox.Visible = false;
        }
        private async void AddresstextBox_Leave(object sender, EventArgs e)
        {
            await Task.Delay(2000);

            AddressSuggestionsListBox.Visible = false;

        }
        private async void GetLocationSuggestions(string input, ListBox suggestionBox)
        {
            if (string.IsNullOrEmpty(googleMapsApiKey))
            {
                MessageBox.Show("API key is not available.");
                return;
            }
            string url = $"https://maps.googleapis.com/maps/api/place/autocomplete/json?input={input}&key={googleMapsApiKey}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(jsonResponse);
                    JArray predictions = (JArray)json["predictions"];
                    suggestionBox.Items.Clear();
                    foreach (var prediction in predictions)
                    {
                        suggestionBox.Items.Add(prediction["description"].ToString());
                    }

                    suggestionBox.Visible = suggestionBox.Items.Count > 0;
                }
                else
                {
                    MessageBox.Show("Error fetching suggestions.");
                }
            }
        }
        private void HotelnumbertextBox_Click(object sender, EventArgs e)
        {
            changeHotelId_Click(null, null);
        }

        private void AddressFromMap_Click(object sender, EventArgs e)
        {
            MapSelectionForm mapForm = new MapSelectionForm(this, googleMapsApiKey);
            if (mapForm.ShowDialog() == DialogResult.OK)
            {
                AddresstextBox.Text = mapForm.SelectedLocation;
                AddressSuggestionsListBox.Visible = false;

                //if (!string.IsNullOrEmpty(AddresstextBox.Text))
                //{
                //    await UpdateMapWithStartAndEndLocations();
                //}
            }
        }
        private async Task InitializeDropDown()
        {
            //ShowTickButtonPictureBox();
            try
            {
                int domainId = int.Parse(GlobalServices.Domainid.ToString());
                _vehicle = await MakeHttpGetRequest<List<Vehicles>>($"api/Vehicle/GetAllVehicles?domainId={domainId}");

                if (_vehicle != null)
                {
                    var placeholder = new Vehicles { VehicleId = -1, PlateNumber = "Select Number Plate" };
                    _vehicle.Insert(0, placeholder);
                    comboBoxNumberPlate.DataSource = _vehicle;
                    comboBoxNumberPlate.DisplayMember = "PlateNumber";
                    comboBoxNumberPlate.ValueMember = "VehicleId";
                    comboBoxNumberPlate.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No vehicles found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HideTickButtonPictureBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing dropdown: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // HideTickButtonPictureBox();
        }

        //private string GetSelectedPlateNumber()
        //{
        //    if (comboboxnumberplate.selecteditem is vehicles selectedvehicle)
        //    {
        //        return selectedvehicle.platenumber;
        //    }
        //    return string.empty;
        //}

    }
}
