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
        private GMapMarker selectedMarker = null;
        public MapForm()
        {
            InitializeComponent();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            InitializeMap();
            gMapControl.OnMarkerClick += GMapControl_OnMarkerClick;
        }
        private void GMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            var localInfo = item.Tag as dynamic;

            if (localInfo != null)
            {
                double latitude = item.Position.Lat;
                double longitude = item.Position.Lng;

                labelName.Text = "Name: " + localInfo.Name;
                labelEmail.Text = "Email: " + localInfo.Email;
                labelCapacity.Text = "Capacidad: " + localInfo.Capacity.ToString();
                labelLatitud.Text = "Latitud: " + latitude.ToString("F6");
                labelLongitud.Text = "Longitud: " + longitude.ToString("F6");
            }
        }

        private void InitializeMap()
        {
            geoWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            geoWatcher.PositionChanged += GeoWatcher_PositionChanged;
            geoWatcher.Start();

            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.MinZoom = 2;
            gMapControl.MaxZoom = 20;
            gMapControl.Zoom = 12;
            gMapControl.ShowCenter = false;

            markersOverlay = new GMapOverlay("markers");

            List<UserLocal> _locals = UsersOrm.SelectLocals();

            foreach (var local in _locals)
            {
                AddPin(local.y_coordination, local.x_coordination, local.name, local.email, local.capacity, GMarkerGoogleType.purple);
            }

            gMapControl.Overlays.Add(markersOverlay);
        }

        private void GeoWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            double latitude = e.Position.Location.Latitude;
            double longitude = e.Position.Location.Longitude;

            gMapControl.Position = new PointLatLng(latitude, longitude);

            geoWatcher.Stop();
        }

        private void AddPin(double lat, double lng, string localName, string email, int capacity, GMarkerGoogleType markerColor)
        {
            var localInfo = new { Name = localName, Email = email, Capacity = capacity };

            GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), markerColor);
            marker.Tag = localInfo;

            markersOverlay.Markers.Add(marker);
        }
        private void ChangeLanguage()
        {
            CultureInfo cultura = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            labelInfo.Text = Strings.localInfo;
            labelTitle.Text = Strings.localInfoTitle;
        }
    }
}
