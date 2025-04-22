using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();

            // Subscribes to the DateChanged event of the month calendar control.
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);

            // Fetches all events from the database using the EventsOrm class.
            var eventos = EventsOrm.SelectEventsCalendar();

            // Filters events for today and binds them to the data source.
            var eventosHoy = eventos.Where(e => e.dateStart.Date == DateTime.Today).ToList();
            bindingSourceEvents.DataSource = eventosHoy;
        }

        /// <summary>
        /// Handles the form's Load event. It is triggered when the form is loaded.
        /// </summary>
        /// <param name="sender">The sender object of the event.</param>
        /// <param name="e">The event data.</param>
        private void CalendarForm_Load(object sender, EventArgs e)
        {
            // Changes the language of the form when it is loaded.
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the DateChanged event of the month calendar control. 
        /// </summary>
        /// <param name="sender">The sender object of the event.</param>
        /// <param name="e">The event data containing the selected date range.</param>
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Retrieves the selected date from the calendar.
            DateTime selectedDate = e.Start;

            // Filters the events based on the selected date and binds them to the data source.
            var filteredEvents = EventsOrm.SelectEventsCalendar()
                                          .Where(evento => evento.dateStart.Date == selectedDate.Date)
                                          .ToList();

            bindingSourceEvents.DataSource = filteredEvents;
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
            // Sets the title label text to the localized string for the calendar title.
            labelTitle.Text = Strings.titleCalendar;
        }
    }
}
