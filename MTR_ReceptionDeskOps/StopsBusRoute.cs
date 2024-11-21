using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace MTRDesktopApplication
{
    public partial class StopsBusRoute : Form
    {
        public List<Stop> Stops { get; private set; }
        private readonly HttpClient httpClient = new HttpClient();
        private string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private string googleMapsApiKey;
        public string stopsOldName = string.Empty;
        public StopsBusRoute(List<Stop> stops)
        {
            InitializeComponent();
            SetRoundButton(close);
            SetRoundButton(Savebutton);
            SetRoundButton(addStop);
            Stops = stops ?? new List<Stop>();
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
        private async Task<string> GetAddressFromCoordinates(string latitude, string longitude)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string apiKey = googleMapsApiKey;
                    string requestUri = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={latitude},{longitude}&key={apiKey}";

                    var response = await client.GetAsync(requestUri);
                    response.EnsureSuccessStatusCode();

                    var content = await response.Content.ReadAsStringAsync();
                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    if (result.status == "OK")
                    {
                        return result.results[0].formatted_address;
                    }
                    else
                    {
                        MessageBox.Show("Error retrieving address: " + result.status);
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving address: " + ex.Message);
                return null;
            }
        }
        private async Task GetLocationSuggestions(string input, ListBox suggestionBox)
        {
            try
            {
                if (string.IsNullOrEmpty(googleMapsApiKey))
                {
                    MessageBox.Show("Google Maps API Key is missing.");
                    return;
                }

                string url = $"https://maps.googleapis.com/maps/api/place/autocomplete/json?input={Uri.EscapeDataString(input)}&key={googleMapsApiKey}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        dynamic data = JObject.Parse(jsonResponse);
                        JArray predictions = data.predictions;

                        suggestionBox.Items.Clear();
                        foreach (var prediction in predictions)
                        {
                            suggestionBox.Items.Add(prediction["description"].ToString());
                        }

                        suggestionBox.Visible = suggestionBox.Items.Count > 0;
                    }
                    else
                    {
                        MessageBox.Show("Failed to fetch suggestions from Google Maps API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching suggestions: {ex.Message}");
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
        private void RemoveDuplicateStops()
        {
            var uniqueStops = Stops
                .GroupBy(s => new { s.Name, s.Latitude, s.Longitude })
                .Select(g => g.First())
                .ToList();
            Stops = uniqueStops;
        }

        private void ClearStopControls()
        {
            panelAddWaypoints.Controls.Clear();
        }
        private async void StopsBusRoute_Load(object sender, EventArgs e)
        {
            ClearStopControls();
            RemoveDuplicateStops();  

            var apiKeyResponse = await MakeHttpGetRequest<ApiKeys>($"api/ApiKeys?domainId={GlobalServices.Domainid}");

            if (apiKeyResponse != null && !string.IsNullOrEmpty(apiKeyResponse.ApiKey))
            {
                googleMapsApiKey = apiKeyResponse.ApiKey;
            }
            else
            {
                ToasterMessages toaster = new ToasterMessages();
                toaster.ShowMessage("Google Maps API key not found. Please go to the Settings Api Key Map  and save the API key there.", MessageType.Error);
                toaster.Show();
                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen.BusRouteScreen();
                return;
            }

            ShowTickButtonPictureBox();
            if (Stops.Count == 0)
            {
                AddStopControlsToPanel();
            }
            else
            {
                foreach (var stop in Stops)
                {
                    AddStopControlsToPanel(stop.Name, stop.Latitude, stop.Longitude, stop.Title);
                }
            }
            HideTickButtonPictureBox();
        }
        private void addStop_Click(object sender, EventArgs e)
        {
            AddStopControlsToPanel();
        }
        private async void Savebutton_Click(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            List<Stop> stops = new List<Stop>();
            try
            {
                foreach (Control control in panelAddWaypoints.Controls)
                {
                    if (control is TextBox stopNameTextBox && stopNameTextBox.Tag?.ToString() == "StopName")
                    {
                        string stopName = stopNameTextBox.Text;
                        string latitude = null;
                        string longitude = null;
                        string title = null;

                        foreach (Control siblingControl in panelAddWaypoints.Controls)
                        {
                            if (siblingControl is TextBox latitudeTextBox && latitudeTextBox.Tag?.ToString() == "Latitude" && latitudeTextBox.Location.Y == stopNameTextBox.Location.Y)
                            {
                                latitude = latitudeTextBox.Text;
                            }
                            if (siblingControl is TextBox longitudeTextBox && longitudeTextBox.Tag?.ToString() == "Longitude" && longitudeTextBox.Location.Y == stopNameTextBox.Location.Y)
                            {
                                longitude = longitudeTextBox.Text;
                            }
                            if (siblingControl is TextBox titleTextBox && titleTextBox.Tag?.ToString() == "Title" && titleTextBox.Location.Y == stopNameTextBox.Location.Y)
                            {
                                title = titleTextBox.Text;
                            }
                        }

                        if (string.IsNullOrEmpty(stopName) && !string.IsNullOrEmpty(latitude) && !string.IsNullOrEmpty(longitude))
                        {
                            stopName = await GetAddressFromCoordinates(latitude, longitude);
                            if (string.IsNullOrEmpty(stopName))
                            {
                                MessageBox.Show("Unable to retrieve address for the provided coordinates.");
                                return;
                            }
                        }

                        if (!string.IsNullOrEmpty(stopName) && (string.IsNullOrEmpty(latitude) || string.IsNullOrEmpty(longitude)))
                        {
                            stops.Add(new Stop { Name = stopName, Latitude = null, Longitude = null, Title = title });
                        }
                        else if (!string.IsNullOrEmpty(latitude) && !string.IsNullOrEmpty(longitude))
                        {
                            stops.Add(new Stop { Name = stopName, Latitude = latitude, Longitude = longitude, Title = title });
                        }
                        else
                        {
                            MessageBox.Show("Please provide either a stop name or both latitude and longitude for each stop.");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                HideTickButtonPictureBox();
            }
            Stops = stops;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AddStopControlsToPanel(string stopName = "", string latitude = "", string longitude = "", string title = "")
        {
            int padding = 20;
            TextBox newStopNameTextBox = new TextBox
            {
                Size = new System.Drawing.Size(260, 20),
                PlaceholderText = "Stop Address",
                Tag = "StopName",
                Text = stopName,
                Font = new System.Drawing.Font("Inter", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            };

            TextBox newTitleTextBox = new TextBox
            {
                Size = new System.Drawing.Size(200, 20),
                PlaceholderText = "Stop Name",
                Tag = "Title",
                Text = title ?? "",
                Font = new System.Drawing.Font("Inter", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            };
            ListBox suggestionBox = new ListBox
            {
                Visible = false,
                Width = 400,
                Height = 60,
                Font = new Font("Inter", 11f, FontStyle.Regular, GraphicsUnit.Point),
                HorizontalScrollbar = true
            };

            newStopNameTextBox.TextChanged += async (s, e) =>
            {
                await GetLocationSuggestions(newStopNameTextBox.Text, suggestionBox);

                if (newStopNameTextBox.Text != stopsOldName)
                {
                    suggestionBox.Location = new Point(newStopNameTextBox.Left, newStopNameTextBox.Bottom);
                    suggestionBox.Visible = true;
                }
                else
                {
                    suggestionBox.Visible = false;
                }
            };

            suggestionBox.SelectedIndexChanged += (s, e) =>
            {
                if (suggestionBox.SelectedItem != null)
                {
                    string selectedItem = suggestionBox.SelectedItem.ToString();
                    stopsOldName = selectedItem;
                    suggestionBox.Visible = false;
                    newStopNameTextBox.Text = selectedItem;
                    string shortTitle = FormatPlaceName(selectedItem);
                    newTitleTextBox.Text = shortTitle;
                    newStopNameTextBox.SelectionStart = newStopNameTextBox.Text.Length;
                    newStopNameTextBox.Focus();
                }
            };

            Button selectLocationButton = new Button
            {
                Text = "Select Location",
                Size = new System.Drawing.Size(120, 40),
                Tag = "SelectLocationButton",
                BackColor = Color.Green,
                ForeColor = Color.White
            };

            selectLocationButton.Click += async (sender, e) =>
            {
                MapSelectionForm mapForm = new MapSelectionForm(this, googleMapsApiKey);
                if (mapForm.ShowDialog() == DialogResult.OK)
                {
                    newStopNameTextBox.Text = mapForm.SelectedLocation;
                }
            };

            System.Windows.Forms.Label orLabel = new System.Windows.Forms.Label
            {
                Size = new System.Drawing.Size(40, 25),
                Text = "OR",
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                ForeColor = Color.Black
            };

            TextBox newLatitudeTextBox = new TextBox
            {
                Size = new System.Drawing.Size(160, 20),
                PlaceholderText = "Latitude",
                Tag = "Latitude",
                Text = latitude,
                Font = new System.Drawing.Font("Inter", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            };

            TextBox newLongitudeTextBox = new TextBox
            {
                Size = new System.Drawing.Size(160, 20),
                PlaceholderText = "Longitude",
                Tag = "Longitude",
                Text = longitude,
                Font = new System.Drawing.Font("Inter", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            };

            Button deleteButton = new Button
            {
                Text = "Delete",
                Tag = "DeleteButton",
                Size = new System.Drawing.Size(90, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Red,
                ForeColor = Color.White
            };

            deleteButton.Click += (sender, e) =>
            {
                panelAddWaypoints.Controls.Remove(newStopNameTextBox);
                panelAddWaypoints.Controls.Remove(suggestionBox);
                panelAddWaypoints.Controls.Remove(newLatitudeTextBox);
                panelAddWaypoints.Controls.Remove(newLongitudeTextBox);
                panelAddWaypoints.Controls.Remove(deleteButton);
                panelAddWaypoints.Controls.Remove(selectLocationButton);
                panelAddWaypoints.Controls.Remove(orLabel);
                panelAddWaypoints.Controls.Remove(newTitleTextBox);

                var stopToRemove = Stops.FirstOrDefault(s => s.Name == newStopNameTextBox.Text && s.Latitude == newLatitudeTextBox.Text && s.Longitude == newLongitudeTextBox.Text);
                if (stopToRemove != null)
                {
                    Stops.Remove(stopToRemove);
                }
            };

            int lowestY = 0;
            foreach (Control control in panelAddWaypoints.Controls)
            {
                if (control.Bottom > lowestY)
                {
                    lowestY = control.Bottom;
                }
            }

            newStopNameTextBox.Location = new System.Drawing.Point(35, lowestY + padding);
            newTitleTextBox.Location = new System.Drawing.Point(newStopNameTextBox.Right + 10, lowestY + padding);
            suggestionBox.Location = new Point(newStopNameTextBox.Left, newStopNameTextBox.Bottom);
            selectLocationButton.Location = new System.Drawing.Point(newTitleTextBox.Right + 10, lowestY + padding);
            orLabel.Location = new System.Drawing.Point(selectLocationButton.Right + 10, lowestY + padding);
            newLatitudeTextBox.Location = new System.Drawing.Point(orLabel.Right + 10, lowestY + padding);
            newLongitudeTextBox.Location = new System.Drawing.Point(newLatitudeTextBox.Right + 10, lowestY + padding);
            deleteButton.Location = new System.Drawing.Point(newLongitudeTextBox.Right + 10, lowestY + padding);

            panelAddWaypoints.Controls.Add(newStopNameTextBox);
            panelAddWaypoints.Controls.Add(newTitleTextBox);
            panelAddWaypoints.Controls.Add(suggestionBox);
            panelAddWaypoints.Controls.Add(newLatitudeTextBox);
            panelAddWaypoints.Controls.Add(newLongitudeTextBox);
            panelAddWaypoints.Controls.Add(selectLocationButton);
            panelAddWaypoints.Controls.Add(orLabel);
            panelAddWaypoints.Controls.Add(deleteButton);
        }

        private string FormatPlaceName(string placeName)
        {
            var parts = placeName.Split(',');
            var cityName = parts[0].Trim();

            const int maxLength = 20;
            if (cityName.Length > maxLength)
            {
                cityName = cityName.Substring(0, maxLength) + "...";
            }
            return cityName;
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
    public class Stop
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Title { get; set; } 
    }
}