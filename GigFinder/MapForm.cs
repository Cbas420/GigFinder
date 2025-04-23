using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Windows.Forms;
using GigFinder.Models;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GigFinder.Resources;
using System.Globalization;
using System.Threading;

namespace GigFinder
{
    public partial class MapForm : Form
    {
        private GeoCoordinateWatcher geoWatcher;
        private GMapOverlay markersOverlay;
        public MapForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the form's Load event. Changes the language and initializes the map.
        /// </summary>
        private void MapForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            InitializeMap();
            gMapControl.OnMarkerClick += GMapControl_OnMarkerClick;
        }

        /// <summary>
        /// Handles the event when a marker on the map is clicked. Displays additional information about the selected marker.
        /// </summary>
        private void GMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            var localInfo = item.Tag as dynamic;

            if (localInfo != null)
            {
                double latitude = item.Position.Lat;
                double longitude = item.Position.Lng;

                labelName.Text = "Name: " + localInfo.Name;
                labelEmail.Text = "Email: " + localInfo.Email;
                labelCapacity.Text = "Capacity: " + localInfo.Capacity.ToString();
                labelLatitud.Text = "Latitude: " + latitude.ToString("F6");
                labelLongitud.Text = "Longitude: " + longitude.ToString("F6");
            }
        }

        /// <summary>
        /// Initializes the map control and sets up the geo-location watcher to track the user's position.
        /// Adds pins for all the local places stored in the database.
        /// </summary>
        private void InitializeMap()
        {
            geoWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            geoWatcher.PositionChanged += GeoWatcher_PositionChanged;
            geoWatcher.Start();

            // Set up the map properties
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.MinZoom = 2;
            gMapControl.MaxZoom = 20;
            gMapControl.Zoom = 12;
            gMapControl.ShowCenter = false;

            markersOverlay = new GMapOverlay("markers");

            // Fetch and add markers for all locals
            List<UserLocal> _locals = UsersOrm.SelectLocals();

            foreach (var local in _locals)
            {
                AddPin(local.y_coordination, local.x_coordination, local.name, local.email, local.capacity, GMarkerGoogleType.purple);
            }

            // Add the markers overlay to the map
            gMapControl.Overlays.Add(markersOverlay);
        }

        /// <summary>
        /// Handles the event when the geo-position of the user changes. Updates the map position to the user's current location.
        /// </summary>
        private void GeoWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            double latitude = e.Position.Location.Latitude;
            double longitude = e.Position.Location.Longitude;

            // Set the map's center to the user's current location
            gMapControl.Position = new PointLatLng(latitude, longitude);

            // Stop the geo watcher after positioning the map
            geoWatcher.Stop();
        }

        /// <summary>
        /// Adds a pin (marker) to the map at the specified coordinates, with associated information.
        /// </summary>
        /// <param name="lat">The latitude of the marker.</param>
        /// <param name="lng">The longitude of the marker.</param>
        /// <param name="localName">The name of the local place.</param>
        /// <param name="email">The email associated with the local place.</param>
        /// <param name="capacity">The capacity of the local place.</param>
        /// <param name="markerColor">The color of the marker.</param>
        private void AddPin(double lat, double lng, string localName, string email, int capacity, GMarkerGoogleType markerColor)
        {
            var localInfo = new { Name = localName, Email = email, Capacity = capacity };

            // Create the marker
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), markerColor);
            marker.Tag = localInfo;

            // Add the marker to the overlay
            markersOverlay.Markers.Add(marker);
        }

        /// <summary>
        /// Changes the language based on the current language setting.
        /// </summary>
        private void ChangeLanguage()
        {
            CultureInfo cultura = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;
            UpdateTexts();
        }

        /// <summary>
        /// Updates the text values on the form according to the current language setting.
        /// </summary>
        private void UpdateTexts()
        {
            labelInfo.Text = Strings.localInfo;
            labelTitle.Text = Strings.localInfoTitle;
        }

    }
}
