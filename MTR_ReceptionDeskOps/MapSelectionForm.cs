using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace MTRDesktopApplication
{
    public partial class MapSelectionForm : Form
    {
        private string googleMapsApiKey;
        public string SelectedLocation { get; private set; }

        public MapSelectionForm(Form parentForm, string apiKey)
        {
            InitializeComponent();
            googleMapsApiKey = apiKey;
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
            DisplayDefaultMap();
        }

        private void DisplayDefaultMap()
        {
            string html = $@"
             <html>
             <head>
                 <meta charset='UTF-8'>
                 <title>Google Maps</title>
                 <script src='https://maps.googleapis.com/maps/api/js?key={googleMapsApiKey}&libraries=places'></script>
                 <script>
                     var map;
                     var marker = null; // Variable to hold the marker
                     var searchBox;

                     function initMap() {{
                         map = new google.maps.Map(document.getElementById('map'), {{
                             center: {{ lat: 40.712776, lng: -74.005974 }},
                             zoom: 12
                         }});
                         
                         searchBox = new google.maps.places.SearchBox(document.getElementById('search-box'));

                         // Bias the SearchBox results towards current map's viewport.
                         map.addListener('bounds_changed', function() {{
                             searchBox.setBounds(map.getBounds());
                         }});
                         
                         searchBox.addListener('places_changed', function() {{
                             var places = searchBox.getPlaces();

                             if (places.length == 0) {{
                                 return;
                             }}

                             // Clear out the old markers.
                             if (marker) {{
                                 marker.setMap(null); // Remove marker from the map
                             }}

                             // For each place, get the icon, name, and location.
                             var bounds = new google.maps.LatLngBounds();
                             places.forEach(function(place) {{
                                 if (!place.geometry) {{
                                     console.log('Returned place contains no geometry');
                                     return;
                                 }}

                                 // Create a marker for each place.
                                 marker = new google.maps.Marker({{
                                     map: map,
                                     position: place.geometry.location
                                 }});

                                 map.setCenter(place.geometry.location);
                                 map.setZoom(15);

                                 // Send address back to C#
                                 window.chrome.webview.postMessage(place.formatted_address);

                                 bounds.union(place.geometry.viewport);
                             }});
                         }});
                         
                         map.addListener('click', function(event) {{
                             var lat = event.latLng.lat();
                             var lng = event.latLng.lng();
                             var geocoder = new google.maps.Geocoder();
                     
                             // Remove the existing marker if there is one
                             if (marker) {{
                                 marker.setMap(null); // Remove marker from the map
                             }}
                     
                             // Create a new marker at the clicked location
                             marker = new google.maps.Marker({{
                                 position: event.latLng,
                                 map: map
                             }});
                     
                             // Geocode the clicked location
                             geocoder.geocode({{ 'location': event.latLng }}, function(results, status) {{
                                 if (status === 'OK') {{
                                     if (results[0]) {{
                                         // Send address back to C#
                                         window.chrome.webview.postMessage(results[0].formatted_address);
                                     }}
                                 }} else {{
                                     console.error('Geocoder failed due to: ' + status);
                                 }}
                             }});
                         }});
                         
                         // Add button to locate user
                         var locateMeButton = document.createElement('button');
                         locateMeButton.textContent = 'Locate Me';
                         locateMeButton.classList.add('custom-map-control-button');
                         map.controls[google.maps.ControlPosition.TOP_RIGHT].push(locateMeButton);
                         
                         locateMeButton.addEventListener('click', function() {{
                             if (navigator.geolocation) {{
                                 navigator.geolocation.getCurrentPosition(function(position) {{
                                     var pos = {{
                                         lat: position.coords.latitude,
                                         lng: position.coords.longitude
                                     }};
                                     map.setCenter(pos);
                                     if (marker) {{
                                         marker.setMap(null); // Remove the existing marker
                                     }}
                                     marker = new google.maps.Marker({{
                                         position: pos,
                                         map: map
                                     }});
                                 }}, function(error) {{
                                     handleLocationError(true, map.getCenter(), error);
                                 }});
                             }} else {{
                                 // Browser doesn't support Geolocation
                                 handleLocationError(false, map.getCenter());
                             }}
                         }});
                         
                         function handleLocationError(browserHasGeolocation, pos, error) {{
                             var message = browserHasGeolocation ? 
                                 'Error: The Geolocation service failed.' : 
                                 'Error: Your browser doesn\'t support geolocation.';
                             if (error) {{
                                 message += ' Details: ' + error.message;
                             }}
                             console.error(message);
                             alert(message);
                         }}
                     }}
                 </script>
                 <style>
                     .custom-map-control-button {{
                         background-color: #fff;
                         border: 2px solid #fff;
                         border-radius: 3px;
                         box-shadow: 0 2px 6px rgba(0,0,0,0.3);
                         cursor: pointer;
                         margin: 10px;
                         padding: 6px;
                         font-size: 14px;
                     }}
                 </style>
             </head>
             <body onload='initMap()' style='margin: 0; padding: 0; height: 100%;'>
                 <input id='search-box' type='text' placeholder='Search for places...' style='width: 100%; padding: 8px; box-sizing: border-box;' />
                 <div id='map' style='width: 100%; height: calc(100% - 40px);'></div>
             </body>
             </html>";

            webView21.NavigateToString(html);
        }

        private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            SelectedLocation = e.WebMessageAsJson.Trim('"');
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

