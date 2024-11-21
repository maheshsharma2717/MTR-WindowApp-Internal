using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class AddStaff : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private Dictionary<string, Image> countryFlags = new Dictionary<string, Image>();
        private string _imagePath = string.Empty;
        public event EventHandler SaveComplete;//For closing popup window after saving the data.
        public long _staffID = 0;
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
          { "+27", "00 000 0000" },     // South Africa
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
          { "+60", "00-0000 0000" },    // Malaysia
          { "+61", "00 0000 0000" },    // Australia
          { "+62", "0000-0000-0000" },  // Indonesia
          { "+63", "0000 000 0000" },   // Philippines
          { "+81", "000-0000-0000" },   // Japan
          { "+82", "00-0000-0000" },    // South Korea
          { "+84", "00 0000 0000" },    // Vietnam
          { "+90", "000 000 0000" },    // Turkey
          { "+91", "00000-00000" },     // India
          { "+92", "000 0000000" },     // Pakistan
          { "+94", "00 000 0000" },     // Sri Lanka
          { "+98", "000 0000 0000" },   // Iran
          { "+213", "00 000 00 00" },   // Algeria
          { "+216", "00 000 000" },     // Tunisia
          { "+218", "00 000 0000" },    // Libya
          { "+221", "00 00 000 00" },   // Senegal
          { "+225", "00 00 00 00 00" }, // Côte d'Ivoire
          { "+226", "00 00 00 00" },    // Burkina Faso
          { "+234", "0000 000 0000" },  // Nigeria
          { "+237", "0000 000 000" },   // Cameroon
          { "+242", "00 000 0000" },    // Congo (Republic)
          { "+243", "00 000 000 000" }, // Congo (Democratic Republic)
          { "+254", "0000 000 000" },   // Kenya
          { "+255", "00 000 0000" },    // Tanzania
          { "+256", "000 000 0000" },   // Uganda
          { "+260", "00 000 0000" },    // Zambia
          { "+261", "00 00 000 00" },   // Madagascar
          { "+263", "00 000 0000" },    // Zimbabwe
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
          { "+509", "00 00 00 00" },    // Haiti
          { "+880", "0000-000000" },    // Bangladesh
          { "+964", "000 000 0000" },   // Iraq
          { "+966", "0000 0000" },      // Saudi Arabia
          { "+971", "00 000 0000" },    // United Arab Emirates
          { "+972", "000-000-0000" },   // Israel
          { "+974", "0000 0000" },      // Qatar
          { "+994", "00 000 00 00" },   // Azerbaijan
          { "+995", "000 00 00" },      // Georgia
        };
        public AddStaff()
        {
            InitializeComponent();

            this.AutoScroll = true;
            GetStates(() =>
            {
                if (staffInfo != null)
                {
                    loadStaffData(staffInfo);
                }
            });
            GetCity(() =>
            {
                if (staffInfo != null)
                {
                    loadStaffData(staffInfo);
                }
            });
            SetRoundPictureBox(pictureBoxCountry, Color.Transparent);
            SetRoundButton(buttonSubmit);
            SetSemiCircleButton(uploadImgButton);
            SetRoundPanel(panelProfileStaffPic, 60, Color.LightGray);
            SetRoundPanel(panelfname, 7, Color.LightGray);
            SetRoundPanel(panellname, 7, Color.LightGray);
            SetRoundPanel(panelEmail, 7, Color.LightGray);
            SetRoundPanel(panelPhoneNo, 7, Color.LightGray);
            SetRoundPanel(panelPosition, 7, Color.LightGray);
            SetRoundPanel(panelAddress, 7, Color.LightGray);
            SetRoundPanel(panelCity, 7, Color.LightGray);
            SetRoundPanel(panelState, 7, Color.LightGray);
            SetRoundPanel(panelZip, 7, Color.LightGray);
            SetRoundPanel(panelExtNo, 7, Color.LightGray);
            SetRoundPanel(panelCreatPassword, 7, Color.LightGray);
            SetRoundPanel(panelConfirmPassword, 7, Color.LightGray);
            SetRoundPanel(panelHourlyRate, 7, Color.LightGray);
            SetRoundPanel(panelFlat, 7, Color.LightGray);
            SetRoundPanel(panelEndDay, 7, Color.LightGray);
            SetRoundPanel(panelStartDay, 7, Color.LightGray);
            SetRoundPanel(panelNotes, 7, Color.LightGray);
            SetRoundPanel(panelDOB, 7, Color.LightGray);
            SetRoundPanel(panelHiredDate, 7, Color.LightGray);
            SetRoundPanel(panelTerminatDate, 7, Color.LightGray);
            comboBoxCountry.DropDownHeight = 100;
            comboBoxCountry.DropDownWidth = 60;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            countryFlags.Add("+1", Properties.Resources.UnitedStates);
            countryFlags.Add("+7", Properties.Resources.Russia);
            countryFlags.Add("+27", Properties.Resources.SouthAfrica);
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
            countryFlags.Add("+60", Properties.Resources.Malaysia);
            countryFlags.Add("+61", Properties.Resources.Australia);
            countryFlags.Add("+62", Properties.Resources.Indonesia);
            countryFlags.Add("+63", Properties.Resources.Philippines);
            countryFlags.Add("+81", Properties.Resources.Japan);
            countryFlags.Add("+82", Properties.Resources.SouthKorea);
            countryFlags.Add("+84", Properties.Resources.Vietnam);
            countryFlags.Add("+90", Properties.Resources.Turkey);
            countryFlags.Add("+91", Properties.Resources.India);
            countryFlags.Add("+92", Properties.Resources.pakistan);
            countryFlags.Add("+94", Properties.Resources.SriLanka);
            countryFlags.Add("+98", Properties.Resources.Iran);
            countryFlags.Add("+213", Properties.Resources.Algeria);
            countryFlags.Add("+216", Properties.Resources.Tunisia);
            countryFlags.Add("+218", Properties.Resources.Libya);
            countryFlags.Add("+221", Properties.Resources.Senegal);
            countryFlags.Add("+225", Properties.Resources.CotedIvoire);
            countryFlags.Add("+226", Properties.Resources.BurkinaFaso);
            countryFlags.Add("+234", Properties.Resources.Nigeria);
            countryFlags.Add("+237", Properties.Resources.Cameroon);
            countryFlags.Add("+242", Properties.Resources.CongoRepublic);
            countryFlags.Add("+243", Properties.Resources.CongoDemocratic);
            countryFlags.Add("+254", Properties.Resources.Kenya);
            countryFlags.Add("+255", Properties.Resources.Tanzania);
            countryFlags.Add("+256", Properties.Resources.Uganda);
            countryFlags.Add("+260", Properties.Resources.Zambia);
            countryFlags.Add("+261", Properties.Resources.Madagascar);
            countryFlags.Add("+263", Properties.Resources.Zimbabwe);
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
            countryFlags.Add("+509", Properties.Resources.Haiti);
            countryFlags.Add("+880", Properties.Resources.Bangladesh);
            countryFlags.Add("+964", Properties.Resources.Iraq);
            countryFlags.Add("+966", Properties.Resources.SaudiArabia);
            countryFlags.Add("+971", Properties.Resources.UAE);
            countryFlags.Add("+972", Properties.Resources.Israel);
            countryFlags.Add("+974", Properties.Resources.Qatar);
            countryFlags.Add("+994", Properties.Resources.Azerbaijan);
            countryFlags.Add("+995", Properties.Resources.Georgia);

            foreach (string countryCode in countryFlags.Keys)
            {
                comboBoxCountry.Items.Add(countryCode);
            }
            uploadImgButton.BackColor = Color.FromArgb(128, 110, 110, 110);
            EndDayDropdown.SelectedIndex = 1;
            startDayDropdown.SelectedIndex = 1;
        }

        private StaffListDto staffInfo;
        private void uploadImgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                panelProfileStaffPic.BackgroundImage = new Bitmap(opnfd.FileName);
                _imagePath = opnfd.FileName;
            }
        }
        private async Task<List<T>> MakeHttpGetListRequest<T>(string endpoint)
        {
            string url = baseUrl + endpoint;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(responseData);
            return default;
        }
        private async void GetStates(Action callback)
        {
            var responsedata = await MakeHttpGetListRequest<States>("api/States");
            if (responsedata != null)
            {
                var placeholder = new States { id = -1, name = "Select State" };
                responsedata.Insert(0, placeholder);

                stateDropdown.DataSource = responsedata;
                stateDropdown.DisplayMember = "Name";
                stateDropdown.ValueMember = "Id";
                stateDropdown.SelectedValue = -1;
                callback?.Invoke();
            }
        }
        private async void GetCity(Action callback)
        {
            var responsedata = await MakeHttpGetListRequest<City>("api/City");
            if (responsedata != null)
            {
                var placeholder = new City { id = -1, name = "Select City" };
                responsedata.Insert(0, placeholder);
                comboBoxCity.DataSource = responsedata;
                comboBoxCity.DisplayMember = "Name";
                comboBoxCity.ValueMember = "Id";
                comboBoxCity.SelectedValue = -1;
                callback?.Invoke();
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
        private void SetSemiCircleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = button.ClientRectangle;
            bounds.Inflate(-1, -1);

            int width = bounds.Width;
            int height = bounds.Height;
            path.AddLine(bounds.X, bounds.Y, bounds.X + width, bounds.Y);
            path.AddArc(bounds.X, bounds.Y - height, width, height * 2, 0, 180);

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
        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool result = isFormvalid();
            if (result)
            {
                ShowTickButtonPictureBox();
                StaffListDto staff = new StaffListDto();
                staff.FirstName = firstNameTextbox.Text;
                staff.LastName = lastNameTextBox.Text;
                staff.Email = emailTextBox.Text;
                staff.CellPhone = textBoxPhoneNumber.Text;
                staff.CountryCode = comboBoxCountry.Text;
                staff.HomePhone = textBoxPhoneNumber.Text;
                staff.Address = addressTextBox.Text;
                staff.Password = createPasswordTextBox.Text;
                staff.Password = confirmPasswordTextBox.Text;
                staff.City = comboBoxCity.Text;
                staff.State = stateDropdown.Text;
                staff.StateId = stateDropdown.SelectedValue.ToString();
                staff.ZipCode = textBoxZip.Text;
                staff.Position = textBoxPosition.Text;
                staff.Notes = textBoxNotes.Text;
                staff.ExtNo = textBoxExtNo.Text;
                staff.AccountingUser = checkBoxAccountingUser?.Checked != null ? 1 : 0;
                staff.AllowRestrictions = AllowRestrictions?.Checked != null ? 1 : 0;
                staff.IsAdmin = checkBoxIsAdmin?.Checked != null ? 1 : 0;
                staff.Status = (checkBoxStatus != null && checkBoxStatus.Checked) ? true : false;
                staff.DOB = DateTime.Parse(dobPicker.Text);
                staff.Profile = !string.IsNullOrWhiteSpace(_imagePath) ? ImageToBase64(_imagePath) : "";
                staff.Id = int.Parse(_staffID.ToString());
                staff.domainid = int.Parse(GlobalServices.Domainid.ToString());
                staff.HourlyRate = int.Parse(textBoxHourlyRate.Text);
                staff.FlatRate = int.Parse(textBoxFlatRate.Text);
                staff.DateHired = DateTime.Parse(dateTimePickerDateHired.Text);
                staff.TerminationDate = DateTime.Parse(dateTimePickerTerminationDate.Text);
                staff.StartDay = startDayDropdown.Text;
                staff.EndDay = EndDayDropdown.Text;
                staff.LoginId = firstNameTextbox.Text + lastNameTextBox.Text;
                bool response = await MakeHttpPostRequest<StaffList>("api/StaffList/AddStaffList", staff);
                HideTickButtonPictureBox();
                SaveComplete?.Invoke(this, EventArgs.Empty);
                this.Close();
                ToasterMessages toaster = new ToasterMessages();
                if (response && _staffID == 0)
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
                else if (response && _staffID > 0)
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
                    toaster.ShowMessage("Failed to update Staff information.!", MessageType.Error);
                    toaster.Show();
                }
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen.StaffListScreen();
            }
        }
        private bool isFormvalid()
        {
            string phoneNumber = textBoxPhoneNumber.Text;
            string selectedCountry = comboBoxCountry.Text?.ToString();
            bool isValid = true;
            firstNameError.Visible = false;
            lastNameError.Visible = false;
            emailError.Visible = false;
            positionError.Visible = false;
            addressError.Visible = false;
            zipError.Visible = false;
            cityError.Visible = false;
            stateError.Visible = false;
            dobError.Visible = false;
            extNoError.Visible = false;
            createPasswordError.Visible = false;
            confirmPasswordError.Visible = false;
            startDayError.Visible = false;
            endDayError.Visible = false;
            hourlyRateError.Visible = false;
            flatRateError.Visible = false;
            hiredDateError.Visible = false;
            terminationDateError.Visible = false;
            PhoneNumberError.Visible = false;
            NotesError.Visible = false;

            if (string.IsNullOrWhiteSpace(firstNameTextbox.Text))
            {
                firstNameError.Visible = true;
                firstNameError.Text = "First name can't be empty";
                isValid = false;
            }
            else if (firstNameTextbox.Text.Length < 2)
            {
                firstNameError.Visible = true;
                firstNameError.Text = "First name must be at least 2 characters long";
                isValid = false;
            }
            else if (!Regex.IsMatch(firstNameTextbox.Text, @"^[a-zA-Z]+$"))
            {
                firstNameError.Visible = true;
                firstNameError.Text = "First name can only contain letters";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                lastNameError.Visible = true;
                lastNameError.Text = " Last name can't be empty";
                isValid = false;
            }
            else if (lastNameTextBox.Text.Length < 2)
            {
                lastNameError.Visible = true;
                lastNameError.Text = "Last name must be at least 2 characters long";
                isValid = false;
            }
            else if (!Regex.IsMatch(lastNameTextBox.Text, @"^[a-zA-Z]+$"))
            {
                lastNameError.Visible = true;
                lastNameError.Text = "Last name can only contain letters";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPosition.Text))
            {
                positionError.Visible = true;
                positionError.Text = "Position can't be empty";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailError.Visible = true;
                emailError.Text = "Email can't be empty";
                isValid = false;
            }
            else if (!IsValidEmail(emailTextBox.Text))
            {
                emailError.Visible = true;
                emailError.Text = "Invalid email format. Example: user@example.com";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                addressError.Visible = true;
                addressError.Text = "Address can't be empty";
                isValid = false;
            }
            else if (addressTextBox.Text.Length < 5)
            {
                addressError.Visible = true;
                addressError.Text = "Address must be at least 5 characters long";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxZip.Text))
            {
                zipError.Visible = true;
                zipError.Text = "ZIP code can't be empty";
                isValid = false;
            }
            if (stateDropdown.SelectedValue == null || (int)stateDropdown.SelectedValue == -1)
            {
                stateError.Visible = true;
                stateError.Text = "State can't be empty";
                return false;
            } 
            if (comboBoxCity.SelectedValue == null || (int)comboBoxCity.SelectedValue == -1)
            {
                cityError.Visible = true;
                cityError.Text = "State can't be empty";
                return false;
            }
            if (string.IsNullOrWhiteSpace(dobPicker.Text))
            {
                dobError.Visible = true;
                dobError.Text = "Date of birth can't be empty";
                isValid = false;
            }
            else if (!DateTime.TryParse(dobPicker.Text, out DateTime dob))
            {
                dobError.Visible = true;
                dobError.Text = "Invalid date format";
                isValid = false;
            }
            else if (dob > DateTime.Now)
            {
                dobError.Visible = true;
                dobError.Text = "Date of birth can't be in the future";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxExtNo.Text))
            {
                extNoError.Visible = true;
                extNoError.Text = "Extension number can't be empty";
                isValid = false;
            }
            else if (!Regex.IsMatch(textBoxExtNo.Text, @"^\d+$"))
            {
                extNoError.Visible = true;
                extNoError.Text = "Extension number must be numeric";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(createPasswordTextBox.Text))
            {
                createPasswordError.Visible = true;
                createPasswordError.Text = "Password can't be empty";
                isValid = false;
            }
            else if (createPasswordTextBox.Text.Length < 8)
            {
                createPasswordError.Visible = true;
                createPasswordError.Text = "Password must be at least 8 characters long";
                isValid = false;
            }
            else if (!Regex.IsMatch(createPasswordTextBox.Text, @"[A-Z]"))
            {
                createPasswordError.Visible = true;
                createPasswordError.Text = "Password must contain at least one uppercase letter";
                isValid = false;
            }
            else if (!Regex.IsMatch(createPasswordTextBox.Text, @"[a-z]"))
            {
                createPasswordError.Visible = true;
                createPasswordError.Text = "Password must contain at least one lowercase letter";
                isValid = false;
            }
            else if (!Regex.IsMatch(createPasswordTextBox.Text, @"[0-9]"))
            {
                createPasswordError.Visible = true;
                createPasswordError.Text = "Password must contain at least one digit";
                isValid = false;
            }
            else if (!Regex.IsMatch(createPasswordTextBox.Text, @"[\W_]"))
            {
                createPasswordError.Visible = true;
                createPasswordError.Text = "Password must contain at least one special character";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                confirmPasswordError.Visible = true;
                confirmPasswordError.Text = "Please confirm your password";
                isValid = false;
            }
            else if (createPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                confirmPasswordError.Visible = true;
                confirmPasswordError.Text = "Passwords do not match";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(startDayDropdown.Text))
            {
                startDayError.Visible = true;
                startDayError.Text = "Start Day can't be empty";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EndDayDropdown.Text))
            {
                endDayError.Visible = true;
                endDayError.Text = "End Day can't be empty";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxHourlyRate.Text))
            {
                hourlyRateError.Visible = true;
                hourlyRateError.Text = "Hourly rate can't be empty";
                isValid = false;
            }
            else if (!decimal.TryParse(textBoxHourlyRate.Text, out decimal hourlyRate) || hourlyRate <= 0)
            {
                hourlyRateError.Visible = true;
                hourlyRateError.Text = "Hourly rate must be a positive number";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxFlatRate.Text))
            {
                flatRateError.Visible = true;
                flatRateError.Text = "Flat rate can't be empty";
                isValid = false;
            }
            else if (!decimal.TryParse(textBoxFlatRate.Text, out decimal flatRate) || flatRate <= 0)
            {
                flatRateError.Visible = true;
                flatRateError.Text = "Flat rate must be a positive number";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(dateTimePickerDateHired.Text))
            {
                hiredDateError.Visible = true;
                hiredDateError.Text = "Date hired can't be empty";
                isValid = false;
            }
            else if (!DateTime.TryParse(dateTimePickerDateHired.Text, out DateTime dateHired))
            {
                hiredDateError.Visible = true;
                hiredDateError.Text = "Invalid date format for date hired";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(dateTimePickerTerminationDate.Text))
            {
                terminationDateError.Visible = true;
                terminationDateError.Text = "Termination date can't be empty";
                isValid = false;
            }
            else if (!DateTime.TryParse(dateTimePickerTerminationDate.Text, out DateTime terminationDate))
            {
                terminationDateError.Visible = true;
                terminationDateError.Text = "Invalid date format for termination date";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                PhoneNumberError.Visible = true;
                PhoneNumberError.Text = "Phone number can't be empty";
                isValid = false;
            }
            else
            {
                string mask = countryPhoneMasks[selectedCountry];
                string numericPhoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());
                int maskDigitCount = mask.Count(c => c == '0');
                if (numericPhoneNumber.Length == maskDigitCount)
                {
                    PhoneNumberError.Visible = false;
                }
                else
                {
                    PhoneNumberError.Visible = true;
                    PhoneNumberError.Text = "Invalid phone number format";
                    isValid = false;
                }
            }
            if (string.IsNullOrWhiteSpace(textBoxNotes.Text))
            {
                NotesError.Visible = true;
                NotesError.Text = "Notes can't be empty";
                isValid = false;
            }
            return isValid;
        }
        private bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
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
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                panelProfileStaffPic.BackgroundImage = image;
            }
        }
        public void loadStaffData(StaffListDto staffInfo)
        {
            this.staffInfo = staffInfo;
            _staffID = (long)staffInfo.Id;
            firstNameTextbox.Text = staffInfo.FirstName;
            lastNameTextBox.Text = staffInfo.LastName;
            emailTextBox.Text = staffInfo.Email;
            var cellPhone = staffInfo.CellPhone.Split('(');
            if (cellPhone.Length == 2)
            {
                textBoxPhoneNumber.Text = "(" + cellPhone[1];
            }
            else
            {
                textBoxPhoneNumber.Text = "(" + cellPhone[0];
            }
            comboBoxCountry.Text = staffInfo.CountryCode;
            addressTextBox.Text = staffInfo.Address;
            createPasswordTextBox.Text = staffInfo.Password;
            confirmPasswordTextBox.Text = staffInfo.Password;
            comboBoxCity.Text = staffInfo.City;
            stateDropdown.Text = staffInfo.State;
            textBoxZip.Text = staffInfo.ZipCode;
            textBoxPosition.Text = staffInfo.Position;
            textBoxNotes.Text = staffInfo.Notes;
            textBoxExtNo.Text = staffInfo.ExtNo;
            textBoxPhoneNumber.Text = staffInfo.HomePhone;
            startDayDropdown.Text = staffInfo.StartDay;
            EndDayDropdown.Text = staffInfo.EndDay;
            textBoxFlatRate.Text = staffInfo.FlatRate?.ToString();
            textBoxHourlyRate.Text = staffInfo.HourlyRate?.ToString();
            checkBoxAccountingUser.Checked = staffInfo.AccountingUser.GetValueOrDefault() != 0;
            AllowRestrictions.Checked = staffInfo.AllowRestrictions.GetValueOrDefault() != 0;
            checkBoxIsAdmin.Checked = staffInfo.IsAdmin.GetValueOrDefault() != 0;
            checkBoxStatus.Checked = staffInfo.Status.GetValueOrDefault() != false;
            dateTimePickerDateHired.Value = staffInfo.DateHired ?? DateTime.Now;
            dateTimePickerTerminationDate.Value = staffInfo.TerminationDate ?? DateTime.Now;
            if (!string.IsNullOrWhiteSpace(staffInfo.Profile))
            {
                UpdateImage(staffInfo.Profile);
            }
            SetSemiCircleButton(uploadImgButton);
        }
        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                textBoxPhoneNumber.SelectionStart = 0;
            }));
        }
        private void textBoxPhoneNumber_Click(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.SelectionStart == 0)
            {
                BeginInvoke(new Action(() =>
                {
                    textBoxPhoneNumber.SelectionStart = 0;
                }));
            }
        }
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = comboBoxCountry.SelectedItem.ToString();
            if (countryFlags.ContainsKey(selectedCountry))
            {
                pictureBoxCountry.Image = countryFlags[selectedCountry];
            }
            if (countryPhoneMasks.ContainsKey(selectedCountry))
            {
                textBoxPhoneNumber.Mask = countryPhoneMasks[selectedCountry];
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
                textBoxPhoneNumber.Mask = countryPhoneMasks[typedCode];
            }
        }

        private string ToTitleCase(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }
        private void firstNameTextbox_TextChanged(object sender, EventArgs e)
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

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
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

        private void textBoxCity_TextChanged(object sender, EventArgs e)
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

        private void addressTextBox_TextChanged(object sender, EventArgs e)
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

        private void textBoxPosition_TextChanged(object sender, EventArgs e)
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
    }
}




