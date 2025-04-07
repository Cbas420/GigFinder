using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigFinder.Models;
using GigFinder.Resources;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace GigFinder
{
    public partial class ResumeDataForm : Form
    {
        private GeoCoordinateWatcher geoWatcher;
        private GMapOverlay markersOverlay;
        public ResumeDataForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }    

        private void ResumeDataForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            InitializeMap();
            gMapControl.OnMarkerClick += GMapControl_OnMarkerClick;
        }
        private void GMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string localName = item.Tag.ToString();

            labelLocal.Text = "Local: " + localName;
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
                AddPin(local.y_coordination, local.x_coordination, local.name, GMarkerGoogleType.purple);
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

        private void AddPin(double lat, double lng, string localName, GMarkerGoogleType markerColor)
        {
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lng), markerColor);

            marker.Tag = localName;

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
        }
    }
}
