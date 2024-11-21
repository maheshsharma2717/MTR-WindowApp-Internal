using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System.Configuration;
using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace MTRDesktopApplication
{
    public partial class BusRoute : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private int currentPage = 1;
        private int pageSize = 8;
        private int totalPages = 0;
        private List<Destination> allDestinations;
        private Destination routeInfo;
        public long _routeId = 0;
        public BusRoute()
        {
            InitializeComponent();
            SetRoundButton(AddBusRoute);
            SetRoundButton(SearchButton);
            SetRoundPanels(panelSearch, 7, Color.LightGray);
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
                DrawRoundedBorder(panel, radius, borderColor, e.Graphics);
            };
            panel.SizeChanged += (sender, e) =>
            {
                UpdateRoundedRegion(panel, radius);
                panel.Invalidate();
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

        private void SetRoundButton(Button button)
        {
            int radius = 15;
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
        private async void BusRoute_Load(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            try
            {
                int domainId = int.Parse(GlobalServices.Domainid.ToString());
                allDestinations = await MakeHttpGetRequest<List<Destination>>("api/Destination", domainId);
                DisplayDestinations(allDestinations);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CustomizeListBox(ListBox listBox)
        {
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.DrawItem += ListBox_DrawItem;
        }
        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = (ListBox)sender;

            string text = listBox.Items[e.Index].ToString();

            e.DrawBackground();
            Brush textBrush = SystemBrushes.ControlText;

            string bullet = "• ";
            e.Graphics.DrawString(bullet + text, e.Font, textBrush, e.Bounds);

            e.DrawFocusRectangle();
        }
        private void DisplayDestinations(List<Destination> destinations)
        {
            mainPanelBusRoute.Controls.Clear();
            if (destinations != null && destinations.Any())
            {
                int panelSpacing = 50;
                foreach (var destination in destinations)
                {
                    Panel panelDetails = new Panel();
                    panelDetails.BackColor = Color.FromArgb(237, 255, 255);
                    panelDetails.Width = 1300;
                    panelDetails.Height = 220;
                    int panelY = 43 + mainPanelBusRoute.Controls.Count * (panelDetails.Height + panelSpacing);
                    panelDetails.Location = new Point(20, panelY);
                    panelDetails.Tag = destination.DestinationId;
                    mainPanelBusRoute.Controls.Add(panelDetails);
                    SetRoundPanel(panelDetails, 12, Color.LightGray);

                    // PictureBox for image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(212, 219);
                    pictureBox.Location = new Point(0, 0);
                    pictureBox.BackColor = Color.White;
                    pictureBox.Image = Properties.Resources.RectangleMap;
                    panelDetails.Controls.Add(pictureBox);
                    SetRoundPictureBox(pictureBox, 15, Color.LightGray);

                    // Add Label for route name
                    Label routeLabel = new Label();
                    routeLabel.Text = destination.DestinationName;
                    routeLabel.Font = new Font("inter", 12, FontStyle.Bold);
                    routeLabel.AutoSize = false;
                    routeLabel.Width = 600;
                    routeLabel.Height = 65;
                    routeLabel.Location = new Point(245, 25);
                    routeLabel.AutoEllipsis= true;
                    panelDetails.Controls.Add(routeLabel);

                    // Label for address
                    Label addressLabel = new Label();
                    addressLabel.Text = destination.FullAddress;
                    addressLabel.Font = new Font("inter", 10);
                    addressLabel.AutoSize = false;
                    addressLabel.Width = 400;
                    addressLabel.Height = 80;
                    addressLabel.Location = new Point(255, 100);
                    addressLabel.TextAlign = ContentAlignment.TopLeft;
                    addressLabel.AutoEllipsis = true;
                    panelDetails.Controls.Add(addressLabel);

                    // PictureBox for address icon
                    PictureBox addressIcon = new PictureBox();
                    addressIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    addressIcon.Image = Properties.Resources.LocationIcon;
                    addressIcon.Size = new Size(15, 15);
                    addressIcon.Location = new Point(240, 105);
                    panelDetails.Controls.Add(addressIcon);

                    // PictureBox for location icon
                    PictureBox locationIcon = new PictureBox();
                    locationIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                    locationIcon.Image = Properties.Resources.mdi_map_marker_distance;
                    locationIcon.Size = new Size(20, 20);
                    locationIcon.Location = new Point(665, 90);
                    panelDetails.Controls.Add(locationIcon);

                    // Label for distance
                    Label distanceLabel = new Label();
                    distanceLabel.Text = destination.Distance + "miles";
                    distanceLabel.Font = new Font("inter", 10);
                    distanceLabel.AutoSize = true;
                    distanceLabel.Location = new Point(685, 90);
                    panelDetails.Controls.Add(distanceLabel);

                    // Label for cost
                    decimal totalCost = 0;
                    if (destination.BusStops.Count() > 0)
                    {
                        totalCost = Convert.ToDecimal(destination.BusStops.OrderBy(x => x.StopId).FirstOrDefault().Cost);
                    }
                    Label costLabel = new Label();
                    costLabel.Text = "Cost: $" + totalCost.ToString("F2");
                    costLabel.Font = new Font("inter", 10);
                    costLabel.AutoSize = true;
                    costLabel.Location = new Point(660, 115);
                    panelDetails.Controls.Add(costLabel);
                    // Label for stops
                    Label stopsLabel = new Label();
                    stopsLabel.Text = "Stops";
                    stopsLabel.Font = new Font("Inter", 10, FontStyle.Bold);
                    stopsLabel.AutoSize = true;
                    stopsLabel.Location = new Point(850,23);
                    panelDetails.Controls.Add(stopsLabel);
                    // ListBox for stops
                    ListBox listBox = new ListBox();
                    listBox.Size = new Size(220, 100);
                    listBox.Location = new Point(855, 55);
                    listBox.Font = new Font("Inter", 10);
                    //listBox.Items.AddRange(destination.BusStops.Select(x => $"{x.StopName} - {x.Distance} miles").ToArray());
                    listBox.Items.AddRange(destination.BusStops.Select(x => $"{x.StopName}-{x.DropStopName}").ToArray());
                    listBox.HorizontalScrollbar = true;
                    listBox.BackColor = Color.FromArgb(0xED, 0xFF, 0xFF);
                    listBox.ScrollAlwaysVisible = false;
                    listBox.BorderStyle = BorderStyle.None;
                    listBox.ItemHeight = 20;
                    panelDetails.Controls.Add(listBox);
                    CustomizeListBox(listBox);
                    // Button for delete route
                    Button deleteButton = new Button();
                    deleteButton.Text = "Delete Route";
                    deleteButton.Size = new Size(130,50);
                    deleteButton.Location = new Point(1130, 120);
                    deleteButton.BackColor = Color.Red;
                    deleteButton.ForeColor = Color.White;
                    deleteButton.Font = new Font("inter", 9);
                    deleteButton.FlatStyle = FlatStyle.Flat;
                    deleteButton.FlatAppearance.BorderSize = 0;
                    GraphicsPath path = new GraphicsPath();
                    Rectangle bounds = deleteButton.ClientRectangle;
                    int radius = 10;
                    bounds.Inflate(-1, -1);
                    path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                    path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
                    path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
                    path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    deleteButton.Region = new Region(path);
                    deleteButton.Click += DeleteButton_Click;
                    panelDetails.Controls.Add(deleteButton);

                    // Button for edit route
                    Button editBtn = new Button();
                    editBtn.Text = "Edit Route";
                    editBtn.Size = new Size(130,50);
                    editBtn.Location = new Point(1130,45);
                    editBtn.BackColor = Color.FromArgb(61, 61, 61);
                    editBtn.ForeColor = Color.White;
                    editBtn.Font = new Font("Inter", 9);
                    editBtn.FlatStyle = FlatStyle.Flat;
                    editBtn.FlatAppearance.BorderSize = 0;
                    GraphicsPath pathedit = new GraphicsPath();
                    Rectangle bound = editBtn.ClientRectangle;
                    int radus = 10;
                    bounds.Inflate(-1, -1);
                    pathedit.AddArc(bound.X, bound.Y, radus, radus, 180, 90);
                    pathedit.AddArc(bound.X + bound.Width - radus, bound.Y, radus, radus, 270, 90);
                    pathedit.AddArc(bound.X + bound.Width - radus, bound.Y + bound.Height - radus, radus, radus, 0, 90);
                    pathedit.AddArc(bound.X, bound.Y + bound.Height - radus, radus, radus, 90, 90);
                    pathedit.CloseFigure();
                    editBtn.Region = new Region(pathedit);
                    editBtn.Click += EditButton_Click;
                    editBtn.Tag = destination.DestinationId;
                    panelDetails.Controls.Add(editBtn);
                }
            }
            else
            {
                MessageBox.Show("No destinations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HideTickButtonPictureBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string id = button.Tag.ToString();
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.AddBusRoutes(int.Parse(id));
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
        private void SearchButton_Click(object sender, EventArgs e)
        {  string searchTerm = SearchBarBusRoute.Text.Trim();
            if (allDestinations != null && allDestinations.Any() && !string.IsNullOrWhiteSpace(searchTerm))
            {
                List<Destination> filteredDestinations = allDestinations
                    .Where(destination =>
                     destination.DestinationName.ToLower().Contains(searchTerm.ToLower()) ||
                     destination.FullAddress.ToLower().Contains(searchTerm.ToLower()) ||
                     destination.Distance.ToString().Contains(searchTerm.ToLower()) ||
                     destination.BusStops.Any(s => s.StopName.ToLower().Contains(searchTerm.ToLower())))
                    .ToList();
                DisplayDestinations(filteredDestinations);
            }
            else
            {
                DisplayDestinations(allDestinations);
            }
          
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
        private async Task<T> MakeHttpDeleteRequest<T>(string endpoint)
        {
            string url = baseUrl + endpoint;
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            string responseData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseData);
        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            Panel panel = (sender as Button)?.Parent as Panel;

            if (panel != null)
            {
                if (panel.Tag is int destinationId)
                {
                    try
                    {
                        string endpoint = $"api/Destination/DeleteDestinationById/{destinationId}";
                        ShowTickButtonPictureBox();
                        var responseData = await MakeHttpDeleteRequest<bool>(endpoint);
                        HideTickButtonPictureBox();
                        ToasterMessages toaster = new ToasterMessages();
                        MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                        mainLayoutScreen.BusRouteScreen();
                        if (responseData)
                        {
                            mainPanelBusRoute.Controls.Remove(panel);
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
                            toaster.ShowMessage("Failed to delete bus information!", MessageType.Error);
                            toaster.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Destination ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Parent panel not found for delete button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddBusRoute_Click_1(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.AddBusRoute();
          
        }
        private void HomeBreadcrumb_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
        }
    }
}
