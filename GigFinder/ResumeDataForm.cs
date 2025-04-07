using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ResumeDataForm : Form
    {
        
        public ResumeDataForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }    

        private void ResumeDataForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void pictureBoxCalendar_Click(object sender, EventArgs e)
        {
            menuCalendar();
        }

        private void labelCalendar_Click(object sender, EventArgs e)
        {
            menuCalendar();
        }

        private void customPanelCalendar_Click(object sender, EventArgs e)
        {
            menuCalendar();
        }

        private void customPanelMap_Click(object sender, EventArgs e)
        {
            menuMap();
        }

        private void labelMap_Click(object sender, EventArgs e)
        {
            menuMap();
        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            menuMap();
        }

        private void customPanelChart_Click(object sender, EventArgs e)
        {
            menuChart();
        }

        private void pictureBoxChart_Click(object sender, EventArgs e)
        {
            menuChart();
        }

        private void labelChart_Click(object sender, EventArgs e)
        {
            menuChart();
        }

        public void menuMap()
        {
            MapForm formMap = new MapForm();
            this.Hide();
            formMap.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formMap.Show();
        }
        public void menuChart()
        {
            ChartsForm formChart = new ChartsForm();
            this.Hide();
            formChart.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formChart.Show();
        }
        public void menuCalendar()
        {
            CalendarForm formCalendar = new CalendarForm();
            this.Hide();
            formCalendar.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formCalendar.Show();
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
