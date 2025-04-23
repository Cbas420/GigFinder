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
        private void CalendarForm_Load(object sender, EventArgs e)
        {
            // Changes the language of the form when it is loaded.
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the DateChanged event of the month calendar control. 
        /// </summary>
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
            labelTitle.Text = Strings.titleCalendar;
        }
    }
}
