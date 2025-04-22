using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Models;
using GigFinder.Resources;
using System.Windows.Forms.DataVisualization.Charting;

namespace GigFinder
{
    public partial class ChartsForm : Form
    {
        public ChartsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the form's Load event. It is triggered when the form is loaded.
        /// </summary>
        /// <param name="sender">The sender object of the event.</param>
        /// <param name="e">The event data.</param>
        private void ChartsForm_Load(object sender, EventArgs e)
        {
            // Changes the language when the form is loaded.
            ChangeLanguage();

            // Initializes the charts with relevant data.
            InitializeCharts();
        }

        /// <summary>
        /// Initializes the charts by setting up the chart types, data points, and colors for the charts.
        /// </summary>
        private void InitializeCharts()
        {
            // Chart for User Types
            chartType.Series[0].ChartType = SeriesChartType.Pie;
            chartType.Series[0].Points.Clear();
            chartType.Series[0].Points.AddXY("Musicians", UsersOrm.SelectMusicians().Count());
            chartType.Series[0].Points.AddXY("Locals", UsersOrm.SelectLocals().Count());
            chartType.Series[0].Points[0].Color = Color.FromArgb(216, 151, 255); // Musicians color
            chartType.Series[0].Points[1].Color = Color.FromArgb(33, 208, 213); // Locals color
            chartType.Series[0].Font = new Font("Inter", 12);
            var title = new Title("User types");
            title.Font = new Font("Passion One", 30, FontStyle.Bold);
            chartType.Titles.Add(title);

            // Chart for Application Statuses
            chartAplications.Series[0].ChartType = SeriesChartType.Pie;
            chartAplications.Series[0].Points.Clear();

            var applications = AplicationsOrm.SelectGlobal();
            var pendingCount = applications.Count(a => a.status == "pendent");
            var acceptedCount = applications.Count(a => a.status == "accepted");
            var rejectedCount = applications.Count(a => a.status == "rejected");

            chartAplications.Series[0].Points.AddXY("Pending", pendingCount);
            chartAplications.Series[0].Points.AddXY("Accepted", acceptedCount);
            chartAplications.Series[0].Points.AddXY("Rejected", rejectedCount);
            chartAplications.Series[0].Points[0].Color = Color.FromArgb(33, 208, 213); // Pending color
            chartAplications.Series[0].Points[1].Color = Color.FromArgb(80, 255, 130); // Accepted color
            chartAplications.Series[0].Points[2].Color = Color.FromArgb(216, 151, 255); // Rejected color
            chartAplications.Series[0].Font = new Font("Inter", 12);
            var appTitle = new Title("Applications Status");
            appTitle.Font = new Font("Passion One", 30, FontStyle.Bold);
            chartAplications.Titles.Add(appTitle);

            // Chart for Event Offer Statuses
            chartEvents.Series[0].ChartType = SeriesChartType.Pie;
            chartEvents.Series[0].Points.Clear();

            var events = EventsOrm.SelectGlobal();
            var openOfferCount = events.Count(e => e.opened_offer == true);
            var closedOfferCount = events.Count(e => e.opened_offer == false);

            chartEvents.Series[0].Points.AddXY("Opened Offer", openOfferCount);
            chartEvents.Series[0].Points.AddXY("Closed Offer", closedOfferCount);
            chartEvents.Series[0].Points[0].Color = Color.FromArgb(33, 208, 213); // Opened offer color
            chartEvents.Series[0].Points[1].Color = Color.FromArgb(216, 151, 255); // Closed offer color
            chartEvents.Series[0].Font = new Font("Inter", 12);
            var eventTitle = new Title("Event Offer Status");
            eventTitle.Font = new Font("Passion One", 30, FontStyle.Bold);
            chartEvents.Titles.Add(eventTitle);
        }

        /// <summary>
        /// Changes the language of the form based on the selected language in the language manager.
        /// </summary>
        private void ChangeLanguage()
        {
            // Sets the culture info based on the selected language in the LanguageManager.
            CultureInfo cultura = new CultureInfo(LanguageManager.language);

            // Applies the culture settings to the current thread.
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;

            // Updates the text of the UI controls after changing the language.
            UpdateTexts();
        }

        /// <summary>
        /// Updates the UI text to reflect the current language.
        /// </summary>
        private void UpdateTexts()
        {
            // Sets the title label text to the localized string for the resume data.
            labelTitle.Text = Strings.resumeData;
        }
    }
}
