using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            InitializeCharts();
        }

        private void InitializeCharts()
        {
            // Chart for User Types
            chartType.Series[0].ChartType = SeriesChartType.Pie;
            chartType.Series[0].Points.Clear();
            chartType.Series[0].Points.AddXY("Musicians", UsersOrm.SelectMusicians().Count());
            chartType.Series[0].Points.AddXY("Locals", UsersOrm.SelectLocals().Count());
            chartType.Series[0].Points[0].Color = Color.FromArgb(216, 151, 255);
            chartType.Series[0].Points[1].Color = Color.FromArgb(33, 208, 213);
            chartType.Series[0].Font = new Font("Inter", 12);
            var title = new Title("User types");
            title.Font = new Font("Passion One", 30, FontStyle.Bold);
            chartType.Titles.Add(title);

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

            // Chart for Event Offers
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

        private void ChangeLanguage()
        {
            CultureInfo cultura = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            labelTitle.Text = Strings.resumeData;
        }
    }
}
