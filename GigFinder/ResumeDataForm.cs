using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
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

        /// <summary>
        /// Handles the form's Load event. Changes the language and initializes the form's components.
        /// </summary>>
        private void ResumeDataForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the click event on the Calendar picture box. Navigates to the Calendar form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void pictureBoxCalendar_Click(object sender, EventArgs e)
        {
            menuCalendar();
        }

        /// <summary>
        /// Handles the click event on the Calendar label. Navigates to the Calendar form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void labelCalendar_Click(object sender, EventArgs e)
        {
            menuCalendar();
        }

        /// <summary>
        /// Handles the click event on the Calendar panel. Navigates to the Calendar form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void customPanelCalendar_Click(object sender, EventArgs e)
        {
            menuCalendar();
        }

        /// <summary>
        /// Handles the click event on the Map panel. Navigates to the Map form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void customPanelMap_Click(object sender, EventArgs e)
        {
            menuMap();
        }

        /// <summary>
        /// Handles the click event on the Map label. Navigates to the Map form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void labelMap_Click(object sender, EventArgs e)
        {
            menuMap();
        }

        /// <summary>
        /// Handles the click event on the Map picture box. Navigates to the Map form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            menuMap();
        }

        /// <summary>
        /// Handles the click event on the Chart panel. Navigates to the Chart form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void customPanelChart_Click(object sender, EventArgs e)
        {
            menuChart();
        }

        /// <summary>
        /// Handles the click event on the Chart picture box. Navigates to the Chart form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void pictureBoxChart_Click(object sender, EventArgs e)
        {
            menuChart();
        }

        /// <summary>
        /// Handles the click event on the Chart label. Navigates to the Chart form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void labelChart_Click(object sender, EventArgs e)
        {
            menuChart();
        }

        /// <summary>
        /// Navigates to the Map form and hides the current form. Shows the current form when the Map form is closed.
        /// </summary>
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

        /// <summary>
        /// Navigates to the Charts form and hides the current form. Shows the current form when the Charts form is closed.
        /// </summary>
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

        /// <summary>
        /// Navigates to the Calendar form and hides the current form. Shows the current form when the Calendar form is closed.
        /// </summary>
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
            labelCalendar.Text = Strings.calendar;
            labelMap.Text = Strings.map;
            labelChart.Text = Strings.chart;
        }

    }
}
