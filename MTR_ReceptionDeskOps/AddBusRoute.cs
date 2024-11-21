using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using MTRDesktopApplication.Dtos;
using System.DirectoryServices.ActiveDirectory;
using Domain.gettaxiusa.com.Entities;
using System.Windows.Forms.VisualStyles;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;
using System.Collections.Immutable;

namespace MTRDesktopApplication
{
    public partial class AddBusRoute : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        public event EventHandler SaveComplete; // For closing popup window after saving the data.
        private string googleMapsApiKey;
        private List<string> stopNames = new List<string>();
        public long _routeID = 0;
        public Destination routeInfo;
        private List<string> titleList = new List<string>();
        private List<(string, string, string, string, double, string)> distanceTimeAndCostList = new List<(string, string, string, string, double, string)>();
        
        
        
        private List<string> waypointsList = new List<string>();
        private List<string> stopNamesOnly = new List<string>();



        private bool _isFetchingDistances = false;
        public string startLocationOldName = string.Empty;
        public string endLocationOldName = string.Empty;
        public List<Stop> stopList =new();
        public AddBusRoute()
        {
            InitializeComponent();
            SetRoundButton(saveBtn);
            SetRoundButton(Search_data);
            SetRoundButton(addStop);
            SetRoundButton(stops);
            SetRoundPanel(panel1, 7, Color.LightGray);
            SetRoundPanel(panel2, 7, Color.LightGray);
            SetRoundPanel(panel4, 7, Color.LightGray);
            SetRoundPanel(panel5, 7, Color.LightGray);
            SetRoundPanel(panel6, 7, Color.LightGray);
            SetRoundPanel(panel8, 7, Color.LightGray);
            SetRoundPanel(panel9, 7, Color.LightGray);
            fairPrmiles.Text = "1.00";
            InitializeDataGridView2();
            UpdateFairPrmilesState();
            enableEndRoute();
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
        private async Task InitBrowser()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        private void homeBreadcrumbs_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.Home();
        }
        private async Task<string> GetAddress(string latitude, string longitude)
        {
            string apiKey = googleMapsApiKey;
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={latitude},{longitude}&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                if (json["results"] != null && json["results"].HasValues && json["results"].Count() > 0)
                {
                    string address = json["results"][0]["formatted_address"].ToString();
                    return address;
                }
                else
                {
                    throw new Exception("No address found for the given coordinates.");
                }
            }
        }
        private async void AddBusRoute_Load(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();

            try
            {
                var apiKeyResponse = await MakeHttpGetRequest<ApiKeys>($"api/ApiKeys?domainId={GlobalServices.Domainid}");

                if (apiKeyResponse != null && !string.IsNullOrEmpty(apiKeyResponse.ApiKey))
                {
                    googleMapsApiKey = apiKeyResponse.ApiKey;
                }
                else
                {
                    ShowApiKeyError();
                    return;
                }
                DisplayDefaultMap();
                await InitBrowser();
                var responseData = await MakeHttpGetRequest<Destination>($"api/Destination/GetDestinationById/{_routeID}");
                if (responseData != null)
                {
                    PopulateFormWithDestination(responseData);
                    PopulateDataGridWithStops(responseData.BusStops);
                    // Search_data_Click(null, null); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HideTickButtonPictureBox();
            }
        }
        private void ShowApiKeyError()
        {
            ToasterMessages toaster = new ToasterMessages();
            toaster.ShowMessage("Google Maps API key not found. Please go to the Settings Api Key Map and save the API key there.", MessageType.Error);
            toaster.Show();
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen?.BusRouteScreen();
        }

        private void PopulateFormWithDestination(Destination responseData)
        {
            startLocationOldName = responseData.FullAddress;
            endLocationOldName = responseData.DestinationName;
            startRoute.Text = responseData.FullAddress;
            endRoute.Text = responseData.DestinationName;
            fairPrmiles.Text = responseData.CostPerMile;
            textBoxLatitude.Text = responseData.Latitude.ToString();
            longitudeTextBox.Text = responseData.Longitude.ToString();
        }

        private async void Search_data_Click(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            string startLocation = startRoute.Text;
            string endLocation = endRoute.Text;
            string[] waypointsArray = waypointsList.ToArray();
            string startLatitude = textBoxLatitude.Text;
            string startLongitude = longitudeTextBox.Text;
            string endLatitude = endLatitudeTextBox.Text;
            string endLongitude = endLongitudeTextBox.Text;
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                var startCoordinates = string.IsNullOrEmpty(startLatitude) || string.IsNullOrEmpty(startLongitude)
                    ? await GetCoordinates(startLocation)
                    : (startLatitude, startLongitude);
                var endCoordinates = string.IsNullOrEmpty(endLatitude) || string.IsNullOrEmpty(endLongitude)
                    ? await GetCoordinates(endLocation)
                    : (endLatitude, endLongitude);
                textBoxLatitude.Text = startCoordinates.Item1;
                longitudeTextBox.Text = startCoordinates.Item2;
                endLatitudeTextBox.Text = endCoordinates.Item1;
                endLongitudeTextBox.Text = endCoordinates.Item2;

                if (string.IsNullOrEmpty(startLocation) && !string.IsNullOrEmpty(startLatitude) && !string.IsNullOrEmpty(startLongitude))
                {
                    startLocation = await GetAddress(startCoordinates.Item1, startCoordinates.Item2);
                    startRoute.Text = startLocation;
                }

                if (string.IsNullOrEmpty(endLocation) && !string.IsNullOrEmpty(endLatitude) && !string.IsNullOrEmpty(endLongitude))
                {
                    endLocation = await GetAddress(endCoordinates.Item1, endCoordinates.Item2);
                    endRoute.Text = endLocation;
                }

                string apiKey = googleMapsApiKey;
                var completeRoute = new List<string> { startLocation };
                completeRoute.AddRange(waypointsArray);
                completeRoute.Add(endLocation);

                string html = $@"
            <html>
            <head>
                <meta charset='UTF-8'>
                <title>Google Maps</title>
                <script src='https://maps.googleapis.com/maps/api/js?key={apiKey}'></script>
                <script>
                    function initMap() {{
                        var map = new google.maps.Map(document.getElementById('map'), {{
                            zoom: 10,
                            center: {{ lat: {startCoordinates.Item1}, lng: {startCoordinates.Item2} }}
                        }});
                
                        var directionsService = new google.maps.DirectionsService();
                        var directionsRenderer = new google.maps.DirectionsRenderer({{
                            map: map,
                            suppressMarkers: true
                        }});
                
                        var start = new google.maps.LatLng({startCoordinates.Item1}, {startCoordinates.Item2});
                        var end = new google.maps.LatLng({endCoordinates.Item1}, {endCoordinates.Item2});
                        var waypoints = [{string.Join(", ", waypointsArray.Select(w => $"{{ location: '{w}', stopover: true }}"))}];
                
                        directionsService.route({{
                            origin: start,
                            destination: end,
                            waypoints: waypoints,
                            travelMode: 'DRIVING'
                        }}, function(response, status) {{
                            if (status === 'OK') {{
                                directionsRenderer.setDirections(response);
                                new google.maps.Marker({{
                                    position: start,
                                    map: map,
                                    label: 'S',
                                    icon: 'http://maps.google.com/mapfiles/ms/icons/green-dot.png'
                                }});
                
                                waypoints.forEach(function(waypoint, index) {{
                                    new google.maps.Marker({{
                                        position: response.routes[0].legs[index].end_location,
                                        map: map,
                                        label: 'W' + (index + 1),
                                        icon: 'http://maps.google.com/mapfiles/ms/icons/red-dot.png'
                                    }});
                                }});
                
                                new google.maps.Marker({{
                                    position: end,
                                    map: map,
                                    label: 'E',
                                    icon: 'http://maps.google.com/mapfiles/ms/icons/blue-dot.png'
                                }});
                            }} else {{
                                window.alert('Directions request failed due to ' + status);
                            }}
                        }});
                    }}
                </script>
            </head>
            <body onload='initMap()'>
                <div id='map' style='width: 100%; height: 100%;'></div>
            </body>
            </html>";

                webView21.NavigateToString(html);
                await FetchAndDisplayDistances(apiKey, completeRoute);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching coordinates: {ex.Message}");
            }
            HideTickButtonPictureBox();
        }


        private async Task FetchAndDisplayDistances(string apiKey, List<string> completeRoute)
        {
            if (_isFetchingDistances)
            {
                return;
            }

            _isFetchingDistances = true;
            try
            {
                if (!double.TryParse(fairPrmiles.Text, out double farePerMile))
                {
                    MessageBox.Show("Please enter a valid fare per mile.");
                    return;
                }

                distanceTimeAndCostList.Clear();
                HashSet<(string, string)> processedSegments = new HashSet<(string, string)>();
                if (completeRoute.Count > 1)
                {
                    var startToEnd = await FetchDistanceTimeAndCost(apiKey, completeRoute.First(), completeRoute.Last(), farePerMile);
                    var titleNames = $"{titleList.ElementAtOrDefault(waypointsList.IndexOf(completeRoute.First())) ?? ""} - {titleList.ElementAtOrDefault(waypointsList.IndexOf(completeRoute.Last())) ?? ""}";
                    //var titleNames = stopNamesOnly;
                    if( stopList.Count > 1)
                    {

                    }
                    
                    distanceTimeAndCostList.Add((completeRoute.First(), completeRoute.Last(), startToEnd.Item1, startToEnd.Item2, startToEnd.Item3, titleNames));
                    processedSegments.Add((completeRoute.First(), completeRoute.Last()));
                }

                for (int i = 0; i < completeRoute.Count; i++)
                {
                    string titleNames = string.Empty;
                   for (int j = i + 1; j < completeRoute.Count; j++)
                    {
                        var origin = completeRoute[i];
                        var destination = completeRoute[j];

                        if (!processedSegments.Contains((origin, destination)) && !processedSegments.Contains((destination, origin)))
                        {
                            processedSegments.Add((origin, destination));
                            if ( stopList.Count > 0)
                            {
                                var find = stopList.Where(x => x.Name == origin).FirstOrDefault();



                                if (find != null)
                                {
                                    var getDestination = distanceTimeAndCostList.FirstOrDefault();
                                    if (getDestination.Item2 == destination)
                                    {
                                        titleNames = find.Title;
                                    }
                                }
                            }
                            var segmentInfo = await FetchDistanceTimeAndCost(apiKey, origin, destination, farePerMile);
                            //var titleNames = $"{titleList.ElementAtOrDefault(waypointsList.IndexOf(origin)) ?? ""} - {titleList.ElementAtOrDefault(waypointsList.IndexOf(destination)) ?? ""}";
                            distanceTimeAndCostList.Add((origin, destination, segmentInfo.Item1, segmentInfo.Item2, segmentInfo.Item3, titleNames));
                        }
                   }
                }

                dataGridView1.Rows.Clear();
                int serialNumber = 1;
                foreach (var (origin, destination, durationText, distanceText, cost, titleNames) in distanceTimeAndCostList)
                {
                    


                    string formattedCost = cost.ToString("F2");
                    dataGridView1.Rows.Add(serialNumber, origin, destination, titleNames, durationText, distanceText, formattedCost);
                    serialNumber++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching distances: {ex.Message}");
            }
            finally
            {
                _isFetchingDistances = false;
            }
        }



        private async Task<(string, string, double)> FetchDistanceTimeAndCost(string apiKey, string origin, string destination, double farePerMile)
        {
            string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={Uri.EscapeDataString(origin)}&destinations={Uri.EscapeDataString(destination)}&units=imperial&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await client.GetStringAsync(url);
                JObject json = JObject.Parse(responseBody);

                if (json["rows"] != null && json["rows"].HasValues &&
                    json["rows"][0]["elements"] != null && json["rows"][0]["elements"].HasValues &&
                    json["rows"][0]["elements"][0]["distance"] != null && json["rows"][0]["elements"][0]["distance"]["text"] != null &&
                    json["rows"][0]["elements"][0]["duration"] != null && json["rows"][0]["elements"][0]["duration"]["text"] != null)
                {
                    string distanceText = json["rows"][0]["elements"][0]["distance"]["text"].ToString();
                    string durationText = json["rows"][0]["elements"][0]["duration"]["text"].ToString();
                    double distanceValue = json["rows"][0]["elements"][0]["distance"]["value"].ToObject<double>() * 0.000621371; // Convert meters to miles
                    double cost = distanceValue * farePerMile;
                    return (distanceText, durationText, cost);
                }
                else
                {
                    throw new Exception("Error fetching distance data from Google Maps API.");
                }
            }
        }

        //private async Task FetchAndDisplayDistances(string apiKey, List<string> completeRoute)
        //{
        //    if (_isFetchingDistances)
        //    {
        //        return;
        //    }

        //    _isFetchingDistances = true;
        //    try
        //    {
        //        if (!double.TryParse(fairPrmiles.Text, out double farePerMile))
        //        {
        //            MessageBox.Show("Please enter a valid fare per mile.");
        //            return;
        //        }

        //        distanceTimeAndCostList.Clear();
        //        HashSet<(string, string)> processedSegments = new HashSet<(string, string)>();
        //        if (completeRoute.Count > 1)
        //        {
        //            var startToEnd = await FetchDistanceTimeAndCost(apiKey, completeRoute.First(), completeRoute.Last(), farePerMile);
        //            var titleNames = $"{titleList.ElementAtOrDefault(stopNamesOnly.IndexOf(completeRoute.First())) ?? ""} - {titleList.ElementAtOrDefault(stopNamesOnly.IndexOf(completeRoute.Last())) ?? ""}";
        //            distanceTimeAndCostList.Add((completeRoute.First(), completeRoute.Last(), startToEnd.Item1, startToEnd.Item2, startToEnd.Item3, titleNames));
        //            processedSegments.Add((completeRoute.First(), completeRoute.Last()));
        //        }

        //        for (int i = 0; i < completeRoute.Count; i++)
        //        {
        //            for (int j = i + 1; j < completeRoute.Count; j++)
        //            {
        //                var origin = completeRoute[i];
        //                var destination = completeRoute[j];

        //                if (!processedSegments.Contains((origin, destination)) && !processedSegments.Contains((destination, origin)))
        //                {
        //                    processedSegments.Add((origin, destination));
        //                    var segmentInfo = await FetchDistanceTimeAndCost(apiKey, origin, destination, farePerMile);
        //                    var titleNames = $"{titleList.ElementAtOrDefault(stopNamesOnly.IndexOf(origin)) ?? ""} - {titleList.ElementAtOrDefault(stopNamesOnly.IndexOf(destination)) ?? ""}";
        //                    distanceTimeAndCostList.Add((origin, destination, segmentInfo.Item1, segmentInfo.Item2, segmentInfo.Item3, titleNames));
        //                }
        //            }
        //        }

        //        dataGridView1.Rows.Clear();
        //        int serialNumber = 1;
        //        foreach (var (origin, destination, durationText, distanceText, cost, titleNames) in distanceTimeAndCostList)
        //        {
        //            string formattedCost = cost.ToString("F2");
        //            dataGridView1.Rows.Add(serialNumber, origin, destination, titleNames, durationText, distanceText, formattedCost);
        //            serialNumber++;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error fetching distances: {ex.Message}");
        //    }
        //    finally
        //    {
        //        _isFetchingDistances = false;
        //    }
        //}
        //private async Task<(string, string, double)> FetchDistanceTimeAndCost(string apiKey, string origin, string destination, double farePerMile)
        //{
        //    string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={Uri.EscapeDataString(origin)}&destinations={Uri.EscapeDataString(destination)}&units=imperial&key={apiKey}";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpResponseMessage response = await client.GetAsync(url);
        //        response.EnsureSuccessStatusCode();
        //        string responseBody = await response.Content.ReadAsStringAsync();
        //        JObject json = JObject.Parse(responseBody);

        //        if (json["rows"] != null && json["rows"].HasValues &&
        //            json["rows"][0]["elements"] != null && json["rows"][0]["elements"].HasValues &&
        //            json["rows"][0]["elements"][0]["distance"] != null && json["rows"][0]["elements"][0]["distance"]["text"] != null &&
        //            json["rows"][0]["elements"][0]["duration"] != null && json["rows"][0]["elements"][0]["duration"]["text"] != null)
        //        {
        //            string distanceText = json["rows"][0]["elements"][0]["distance"]["text"].ToString();
        //            string durationText = json["rows"][0]["elements"][0]["duration"]["text"].ToString();
        //            double distanceValue = json["rows"][0]["elements"][0]["distance"]["value"].ToObject<double>() * 0.000621371; // Convert meters to miles
        //            double cost = distanceValue * farePerMile;
        //            return (distanceText, durationText, cost);
        //        }
        //        else
        //        {
        //            throw new Exception($"No distance or duration found from {origin} to {destination}");
        //        }
        //    }
        //}

        private async Task<(string, string)> GetCoordinates(string address)
        {
            string apiKey = googleMapsApiKey;
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={Uri.EscapeDataString(address)}&key={apiKey}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);

                    if (json["results"] != null && json["results"].HasValues && json["results"].Count() > 0)
                    {
                        string latitude = json["results"][0]["geometry"]["location"]["lat"].ToString();
                        string longitude = json["results"][0]["geometry"]["location"]["lng"].ToString();
                        return (latitude, longitude);
                    }
                    else
                    {
                        throw new Exception("No coordinates found for the given address.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private async Task<(double distanceInMiles, string travelTime)> GetDistanceAndTime(string origin, string destination)
        {
            string apiKey = googleMapsApiKey;
            string requestUrl = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={Uri.EscapeDataString(origin)}&destinations={Uri.EscapeDataString(destination)}&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseBody);

                    if (jsonResponse.rows[0].elements[0].status == "OK")
                    {
                        double distanceInMeters = jsonResponse.rows[0].elements[0].distance.value;
                        double distanceInMiles = distanceInMeters * 0.000621371;
                        string travelTime = jsonResponse.rows[0].elements[0].duration.text;
                        return (distanceInMiles, travelTime);
                    }
                }
            }
            throw new Exception("Failed to get distance and travel time.");
        }


        private async void saveBtn_Click(object sender, EventArgs e)
        {
            ShowTickButtonPictureBox();
            string startRouteText = startRoute.Text;
            string endRouteText = endRoute.Text;
            string costPerMile = fairPrmiles.Text;

            if (string.IsNullOrEmpty(startRouteText))
            {
                MessageBox.Show("Start route is empty. Please fill in all fields.");
                return;
            }

            if (string.IsNullOrEmpty(endRouteText))
            {
                MessageBox.Show("End route is empty. Please fill in all fields.");
                return;
            }

            List<BusStops> busStops = new List<BusStops>();

            try
            {
                var startCoordinates = await GetCoordinates(startRouteText);
                var endCoordinates = await GetCoordinates(endRouteText);

                foreach (var (name, destination, distance, duration, cost, titleNames) in distanceTimeAndCostList.Distinct())
                {

                   // var findStopName = 
                    busStops.Add(new BusStops
                    {
                        StopId = 0,
                        StopName = name,
                        DropStopName = destination,
                        DestinationId = 0,
                        Distance = distance,
                        TravelingTime = duration,
                        TitleName = titleNames,
                        Cost = cost.ToString(),
                        
                        
                    });
                }

                if (!decimal.TryParse(startCoordinates.Item1, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal startLatitude) ||
                    !decimal.TryParse(startCoordinates.Item2, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal startLongitude) ||
                    !decimal.TryParse(endCoordinates.Item1, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal endLatitude) ||
                    !decimal.TryParse(endCoordinates.Item2, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal endLongitude))
                {
                    throw new Exception("Failed to parse coordinates.");
                }

                var (totalDistance, totalTravelTime) = await GetDistanceAndTime(startRouteText, endRouteText);

                Destination route = new Destination
                {
                    DestinationId = int.Parse(_routeID.ToString()),
                    DestinationName = endRouteText,
                    Latitude = startLatitude,
                    Longitude = startLongitude,
                    FullAddress = startRouteText,
                    State = "",
                    District = "",
                    ZipCode = 0,
                    City = "",
                    Distance = (int)totalDistance,
                    TravelingTime = totalTravelTime,
                    CostPerMile = costPerMile,
                    DomainId = int.Parse(GlobalServices.Domainid),
                    BusStops = busStops
                };

                string json = JsonConvert.SerializeObject(route);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync($"{baseUrl}api/Destination/AddDestination", content);
                response.EnsureSuccessStatusCode();

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
                SaveComplete?.Invoke(this, EventArgs.Empty);
                this.Close();

                MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
                mainLayoutScreen?.BusRouteScreen();
            }
            catch (Exception ex)
            {
                ToasterMessages toaster = new ToasterMessages();
                toaster.ShowMessage("Failed to update Vehicle information!", MessageType.Error);
                toaster.Show();
            }
            finally
            {
                HideTickButtonPictureBox();
            }
        }
        private async void DisplayDefaultMap()
        {
            await webView21.EnsureCoreWebView2Async(null);
            string defaultLocation = "New York, NY";
            string apiKey = googleMapsApiKey;
            string url = $"https://www.google.com/maps/embed/v1/place?key={apiKey}&q={Uri.EscapeDataString(defaultLocation)}";
            string html = $@"
             <html>
               <head>
                   <meta charset='UTF-8'>
                   <title>Google Maps</title>
               </head>
               <body>
                   <iframe width='100%' height='100%' frameborder='0' style='border:0' src='{url}' allowfullscreen></iframe>
               </body>
             </html>";
            webView21.NavigateToString(html);
        }
        private void busRouteBreadcrumbs_Click(object sender, EventArgs e)
        {
            MainLayoutScreen mainLayoutScreen = Application.OpenForms.OfType<MainLayoutScreen>().FirstOrDefault();
            mainLayoutScreen.BusRouteScreen();
        }
        public void GetSelectedBusRouteId(long id)
        {
            _routeID = id;
            this.Load += AddBusRoute_Load;
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
        private async Task UpdateMapWithStartLocation()
        {
            try
            {
                string startLocation = startRoute.Text;
                var startCoordinates = await GetCoordinates(startLocation);
                string apiKey = googleMapsApiKey;
                string html = $@"
                <html>
                <head>
                    <meta charset='UTF-8'>
                    <title>Google Maps</title>
                    <script src='https://maps.googleapis.com/maps/api/js?key={apiKey}'></script>
                    <script>
                        function initMap() {{
                            var map = new google.maps.Map(document.getElementById('map'), {{
                                zoom: 10,
                                center: {{ lat: {startCoordinates.Item1}, lng: {startCoordinates.Item2} }}
                            }});

                            var start = new google.maps.LatLng({startCoordinates.Item1}, {startCoordinates.Item2});

                            // Add marker for start location
                            new google.maps.Marker({{
                                position: start,
                                map: map,
                                label: 'S',
                                icon: 'http://maps.google.com/mapfiles/ms/icons/green-dot.png'
                            }});
                        }}
                    </script>
                </head>
                <body onload='initMap()'>
                    <div id='map' style='width: 100%; height: 100%;'></div>
                </body>
                </html>";

                webView21.NavigateToString(html);
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"Error updating map with start location: {ex.Message}");
            }
        }
        private async Task UpdateMapWithStartAndEndLocations()
        {
            try
            {
                string startLocation = startRoute.Text;
                string endLocation = endRoute.Text;
                var startCoordinates = await GetCoordinates(startLocation);
                var endCoordinates = await GetCoordinates(endLocation);
                string apiKey = googleMapsApiKey;
                string html = $@"
                <html>
                <head>
                    <meta charset='UTF-8'>
                    <title>Google Maps</title>
                    <script src='https://maps.googleapis.com/maps/api/js?key={apiKey}'></script>
                    <script>
                        function initMap() {{
                            var map = new google.maps.Map(document.getElementById('map'), {{
                                zoom: 10,
                                center: {{ lat: {startCoordinates.Item1}, lng: {startCoordinates.Item2} }}
                            }});

                            var start = new google.maps.LatLng({startCoordinates.Item1}, {startCoordinates.Item2});
                            var end = new google.maps.LatLng({endCoordinates.Item1}, {endCoordinates.Item2});

                            // Add markers for start and end locations
                            new google.maps.Marker({{
                                position: start,
                                map: map,
                                label: 'S',
                                icon: 'http://maps.google.com/mapfiles/ms/icons/green-dot.png'
                            }});

                            new google.maps.Marker({{
                                position: end,
                                map: map,
                                label: 'E',
                                icon: 'http://maps.google.com/mapfiles/ms/icons/blue-dot.png'
                            }});

                            // Draw route between start and end locations
                            var directionsService = new google.maps.DirectionsService();
                            var directionsRenderer = new google.maps.DirectionsRenderer({{
                                map: map,
                                suppressMarkers: true
                            }});

                            directionsService.route({{
                                origin: start,
                                destination: end,
                                travelMode: 'DRIVING'
                            }}, function(response, status) {{
                                if (status === 'OK') {{
                                    directionsRenderer.setDirections(response);
                                }} else {{
                                    window.alert('Directions request failed due to ' + status);
                                }}
                            }});
                        }}
                    </script>
                </head>
                <body onload='initMap()'>
                    <div id='map' style='width: 100%; height: 100%;'></div>
                </body>
                </html>";

                webView21.NavigateToString(html);
            }
            catch (Exception ex)
            {
                //  MessageBox.Show($"Error updating map with start and end locations: {ex.Message}");
            }
        }
        private async void startRoute_TextChanged(object sender, EventArgs e)
        {
            UpdateFairPrmilesState();
            enableEndRoute();
            if (startRoute.Text != startLocationOldName)
            {
                string input = startRoute.Text.Trim();
                GetLocationSuggestions(input, startRouteSuggestionsListBox);
                startRouteSuggestionsListBox.Visible = true;
            }
        }
        private async void endRoute_TextChanged(object sender, EventArgs e)
        {
            UpdateFairPrmilesState();
            if (endRoute.Text != endLocationOldName)
            {
                string input = endRoute.Text.Trim();
                GetLocationSuggestions(input, endRouteSuggestionsListBox);
                endRouteSuggestionsListBox.Visible = true;
            }
        }

        private void startRouteSuggestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startRouteSuggestionsListBox.SelectedItem != null)
            {
                string selectedName = startRouteSuggestionsListBox.SelectedItem.ToString();
                startLocationOldName = selectedName;
                startRouteSuggestionsListBox.Visible = false;
                startRoute.Text = selectedName;
                UpdateMapWithStartLocation();
            }
        }

        private void endRouteSuggestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (endRouteSuggestionsListBox.SelectedItem != null)
            {
                string selectedName = endRouteSuggestionsListBox.SelectedItem.ToString();
                endLocationOldName = selectedName;
                endRouteSuggestionsListBox.Visible = false;
                endRoute.Text = selectedName;
                UpdateMapWithStartAndEndLocations();
                Search_data_Click(null, null);
            }
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
        private async void startMapBtn_Click(object sender, EventArgs e)
        {
            MapSelectionForm mapForm = new MapSelectionForm(this, googleMapsApiKey);
            if (mapForm.ShowDialog() == DialogResult.OK)
            {
                startLocationOldName = mapForm.SelectedLocation;
                startRoute.Text = mapForm.SelectedLocation;
                await UpdateMapWithStartLocation();
            }
        }

        private async void endMapBtn_Click(object sender, EventArgs e)
        {
            MapSelectionForm mapForm = new MapSelectionForm(this, googleMapsApiKey);
            if (mapForm.ShowDialog() == DialogResult.OK)
            {
                endLocationOldName = mapForm.SelectedLocation;
                endRoute.Text = mapForm.SelectedLocation;
                if (!string.IsNullOrEmpty(startRoute.Text))
                {
                    await UpdateMapWithStartAndEndLocations();
                }
            }
        }
        private void PopulateDataGridWithStops(IEnumerable<BusStops> busStops)
        {
            dataGridView1.Rows.Clear();
            stopNamesOnly.Clear();
            waypointsList.Clear();
            int sNo = 1;
            bool isFirst = true;
            stopList =new List<Stop>();
            foreach (var stop in busStops)
            {
                // Filter out unnecessary stops
                if (isFirst || !string.IsNullOrEmpty(stop.DropStopName))
                {
                    string firstName = !string.IsNullOrEmpty(stop.StopName) ? stop.StopName : "";
                    string destination = !string.IsNullOrEmpty(stop.DropStopName) ? stop.DropStopName : "";
                    string titleName = !string.IsNullOrEmpty(stop.TitleName) ? stop.TitleName : "";

                    if (!isFirst && !string.IsNullOrEmpty(destination))
                    {
                        if(stop.TitleName != " - " && stop.TitleName != "") {
                            waypointsList.Add(stop.StopName);
                            stopNamesOnly.Add(titleName);
                        }
                       
                    }

                    isFirst = false;
                    dataGridView1.Rows.Add(sNo++, firstName, destination, titleName, stop.Distance, stop.TravelingTime, stop.Cost);

                    Stop addStop = new Stop();
                    addStop.Name = firstName;
                    addStop.Title = titleName;

                    stopList.Add(addStop);


                }
            }
            
            // Search_data_Click(null, null);
        }

        private void addStop_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;

            var stops = new List<Stop>();

            // Filter relevant stops
            var relevantStops = waypointsList
                .Select((name, index) => new Stop
                {
                    Name = name,
                    Latitude = "",
                    Longitude = "",
                    Title = stopNamesOnly.Count > index ? stopNamesOnly[index] : ""
                })
                .ToList();



            // If no waypoints are available, use stopNamesOnly directly
            if (!relevantStops.Any() && stopNamesOnly.Any())
            {
                relevantStops = stopNamesOnly
                    .Select(name => new Stop
                    {
                        Name = name,
                        Latitude = "",
                        Longitude = "",
                        Title = name,
                    })
                    .ToList();
            }


            foreach (var stop in relevantStops)
            {
                Debug.WriteLine($"Name: {stop.Name}, Title: {stop.Title}");
            }

            using (StopsBusRoute popup = new StopsBusRoute(relevantStops))
            {
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.FormClosed += (s, args) =>
                {
                    if (popup.DialogResult == DialogResult.OK)
                    {
                        waypointsList = popup.Stops.Select(stop => stop.Name).ToList();
                        stopNamesOnly = popup.Stops.Select(stop => stop.Title).ToList();
                        stopList = popup.Stops;
                         




                      //  mainOnly=popup.Stops.Select(stop => stop.Main).ToList();

                        Search_data_Click(null, null);
                    }
                };
                popup.ShowDialog();
            }
        }

        //private async void Search_data_Click(object sender, EventArgs e)
        //{
        //    ShowTickButtonPictureBox();
        //    string startLocation = startRoute.Text;
        //    string endLocation = endRoute.Text;
        //    string[] waypointsArray = waypointsList.ToArray();
        //    string[] stopnameArray = stopNamesOnly.ToArray();
        //    string startLatitude = textBoxLatitude.Text;
        //    string startLongitude = longitudeTextBox.Text;
        //    string endLatitude = endLatitudeTextBox.Text;
        //    string endLongitude = endLongitudeTextBox.Text;
        //    try
        //    {
        //        dataGridView1.Rows.Clear();
        //        dataGridView2.Rows.Clear();

        //        var startCoordinates = string.IsNullOrEmpty(startLatitude) || string.IsNullOrEmpty(startLongitude)
        //            ? await GetCoordinates(startLocation)
        //            : (startLatitude, startLongitude);
        //        var endCoordinates = string.IsNullOrEmpty(endLatitude) || string.IsNullOrEmpty(endLongitude)
        //            ? await GetCoordinates(endLocation)
        //            : (endLatitude, endLongitude);
        //        textBoxLatitude.Text = startCoordinates.Item1;
        //        longitudeTextBox.Text = startCoordinates.Item2;
        //        endLatitudeTextBox.Text = endCoordinates.Item1;
        //        endLongitudeTextBox.Text = endCoordinates.Item2;

        //        if (string.IsNullOrEmpty(startLocation) && !string.IsNullOrEmpty(startLatitude) && !string.IsNullOrEmpty(startLongitude))
        //        {
        //            startLocation = await GetAddress(startCoordinates.Item1, startCoordinates.Item2);
        //            startRoute.Text = startLocation;
        //        }

        //        if (string.IsNullOrEmpty(endLocation) && !string.IsNullOrEmpty(endLatitude) && !string.IsNullOrEmpty(endLongitude))
        //        {
        //            endLocation = await GetAddress(endCoordinates.Item1, endCoordinates.Item2);
        //            endRoute.Text = endLocation;
        //        }

        //        string apiKey = googleMapsApiKey;
        //        var completeRoute = new List<string> { startLocation };
        //        completeRoute.AddRange(waypointsArray);
        //        completeRoute.Add(endLocation);
        //        string html = $@"
        //         <html>
        //         <head>
        //             <meta charset='UTF-8'>
        //             <title>Google Maps</title>
        //             <script src='https://maps.googleapis.com/maps/api/js?key={apiKey}'></script>
        //             <script>
        //                 function initMap() {{
        //                     var map = new google.maps.Map(document.getElementById('map'), {{
        //                         zoom: 10,
        //                         center: {{ lat: {startCoordinates.Item1}, lng: {startCoordinates.Item2} }}
        //                     }});
                     
        //                     var directionsService = new google.maps.DirectionsService();
        //                     var directionsRenderer = new google.maps.DirectionsRenderer({{
        //                         map: map,
        //                         suppressMarkers: true
        //                     }});
                     
        //                     var start = new google.maps.LatLng({startCoordinates.Item1}, {startCoordinates.Item2});
        //                     var end = new google.maps.LatLng({endCoordinates.Item1}, {endCoordinates.Item2});
        //                     var waypoints = [{string.Join(", ", waypointsArray.Select(w => $"{{ location: '{w}', stopover: true }}"))}];
                     
        //                     directionsService.route({{
        //                         origin: start,
        //                         destination: end,
        //                         waypoints: waypoints,
        //                         travelMode: 'DRIVING'
        //                     }}, function(response, status) {{
        //                         if (status === 'OK') {{
        //                             directionsRenderer.setDirections(response);
        //                             // Add custom markers for waypoints 
        //                             new google.maps.Marker({{
        //                                 position: start,
        //                                 map: map,
        //                                 label: 'S',
        //                                 icon: 'http://maps.google.com/mapfiles/ms/icons/green-dot.png'
        //                             }});
                     
        //                             waypoints.forEach(function(waypoint, index) {{
        //                                 new google.maps.Marker({{
        //                                     position: response.routes[0].legs[index].end_location,
        //                                     map: map,
        //                                     label: 'W' + (index + 1),
        //                                     icon: 'http://maps.google.com/mapfiles/ms/icons/red-dot.png'
        //                                 }});
        //                             }});
                     
        //                             new google.maps.Marker({{
        //                                 position: end,
        //                                 map: map,
        //                                 label: 'E',
        //                                 icon: 'http://maps.google.com/mapfiles/ms/icons/blue-dot.png'
        //                             }});
        //                         }} else {{
        //                             window.alert('Directions request failed due to ' + status);
        //                         }}
        //                     }});
        //                 }}
        //             </script>
        //         </head>
        //         <body onload='initMap()'>
        //             <div id='map' style='width: 100%; height: 100%;'></div>
        //         </body>
        //         </html>";

        //        webView21.NavigateToString(html);
        //        await FetchAndDisplayDistances(apiKey, completeRoute);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error fetching coordinates: {ex.Message}");
        //    }
        //    HideTickButtonPictureBox();
        //}

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            int sNo = 1;

            for (int i = 0; i < waypointsList.Count; i++)
            {
                string name = waypointsList[i];
                string title = stopNamesOnly.Count > i ? stopNamesOnly[i] : "";
            }
        }
        private void stops_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            InitializeDataGridView2(); 
            PopulateDataGridView2();
            dataGridView2.Visible = true;
        }
       
        private void InitializeDataGridView2()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("SNo", "S/N");
            dataGridView2.Columns.Add("Title", "Stop Name");
            dataGridView2.Columns.Add("Type", "Type");
            dataGridView2.Columns.Add("StopName", "Stop Address/Location");
            dataGridView2.Columns.Add("Distance", "Distance");
            dataGridView2.Columns.Add("Time", "Time");
            dataGridView2.Columns["SNo"].Width = 70;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }

        private async void PopulateDataGridView2()
        {
            dataGridView2.Rows.Clear();
            var stops = new List<(int SNo, string StopName, string Type, string Title, string Distance, string Time)>();
            string fullStartRoute = startRoute.Text;
            string shortStartRoute = FormatPlaceName(fullStartRoute);
            stops.Add((1, fullStartRoute, "Starting Terminal", shortStartRoute, "", ""));

            for (int i = 0; i < waypointsList.Count; i++)
            {
                  
                string fromStop = i == 0 ? startRoute.Text : waypointsList[i - 1];
                string toStop = waypointsList[i];
                var distanceTime = await GetSegmentDistanceAndTime(fromStop, toStop);
                string fullTitle = i < stopNamesOnly.Count ? stopNamesOnly[i] : "";
                string shortStopName = FormatPlaceName(toStop);
                 
                stops.Add((i + 2, toStop, "Stop", fullTitle, distanceTime.Distance, distanceTime.Time));
            }

            var lastStop = waypointsList.LastOrDefault();
            if (lastStop != null)
            {
                var distanceTime = await GetSegmentDistanceAndTime(lastStop, endRoute.Text);
                string fullEndRoute = endRoute.Text;
                string shortEndRoute = FormatPlaceName(fullEndRoute);

                stops.Add((stops.Count + 1, fullEndRoute, "End Terminal", shortEndRoute, distanceTime.Distance, distanceTime.Time));
            }
            else if (!string.IsNullOrEmpty(endRoute.Text))
            {
                var distanceTime = await GetSegmentDistanceAndTime(startRoute.Text, endRoute.Text);
                string fullEndRoute = endRoute.Text;
                string shortEndRoute = FormatPlaceName(fullEndRoute);

                stops.Add((2, fullEndRoute, "End Terminal", shortEndRoute, distanceTime.Distance, distanceTime.Time));
            }

            foreach (var stop in stops)
            {
                dataGridView2.Rows.Add(stop.SNo, stop.Title, stop.Type, stop.StopName, stop.Distance, stop.Time);
            }
        }

        private async Task<(string Distance, string Time)> GetSegmentDistanceAndTime(string origin, string destination)
        {
            string apiKey = googleMapsApiKey;
            string requestUrl = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={Uri.EscapeDataString(origin)}&destinations={Uri.EscapeDataString(destination)}&key={apiKey}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseBody);

                    if (jsonResponse.rows[0].elements[0].status == "OK")
                    {
                        double distanceInMeters = jsonResponse.rows[0].elements[0].distance.value;
                        double distanceInMiles = distanceInMeters * 0.000621371;
                        string travelTime = jsonResponse.rows[0].elements[0].duration.text;
                        return (distanceInMiles.ToString("0.##") + " mi", travelTime);
                    }
                }
            }
            throw new Exception("Failed to get distance and travel time.");
        }

        private async void startRoute_Leave(object sender, EventArgs e)
        {
            string startLocation = startRoute.Text.Trim();
            if (!string.IsNullOrEmpty(startLocation))
            {
                await UpdateMapWithStartLocation();
            }
            startRouteSuggestionsListBox.Visible = false;
        }

        private async void endRoute_Leave(object sender, EventArgs e)
        {
            string endLocation = endRoute.Text.Trim();
            if (!string.IsNullOrEmpty(startRoute.Text) && !string.IsNullOrEmpty(endLocation))
            {
                await UpdateMapWithStartAndEndLocations();
            }
            endRouteSuggestionsListBox.Visible = false;
            Search_data_Click(null, null);
        }

        private void startRouteSuggestionsListBox_Click(object sender, EventArgs e)
        {
            startRouteSuggestionsListBox.Visible = false;
        }

        private void endRouteSuggestionsListBox_Click(object sender, EventArgs e)
        {
            endRouteSuggestionsListBox.Visible = false;
        }
        private void UpdateFairPrmilesState()
        {
            fairPrmiles.Enabled = !string.IsNullOrWhiteSpace(startRoute.Text) && !string.IsNullOrWhiteSpace(endRoute.Text);
        }
        private void enableEndRoute()
        {
            endRoute.Enabled = !string.IsNullOrWhiteSpace(startRoute.Text);
        }

        private void fairPrmiles_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (decimal.TryParse(textBox.Text, out decimal value))
                {
                    textBox.Text = value.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Invalid cost value. Please enter a valid number.");
                    textBox.Focus();
                    return;
                }
                Search_data_Click(null, null);
            }
            else
            {
                MessageBox.Show("Cost is required to calculate the travel expenses");
                textBox.Focus();
            }
        }
        public string FormatPlaceName(string placeName)
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

        private void fairPrmiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numeric values.");
            }
        }
    }

    public class StopList
    {
        public string wayPointName { get; set; }
        public string stopName { get; set; }
    }
}
