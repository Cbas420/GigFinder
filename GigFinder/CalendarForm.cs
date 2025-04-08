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

            var eventos = EventsOrm.SelectEventsCalendar();

            var eventosHoy = eventos.Where(e => e.dateStart.Date == DateTime.Today).ToList();

            bindingSourceEvents.DataSource = eventosHoy;
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;

            var filteredEvents = EventsOrm.SelectEventsCalendar()
                                              .Where(evento => evento.dateStart.Date == selectedDate.Date)
                                              .ToList();

            bindingSourceEvents.DataSource = filteredEvents;
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
            labelTitle.Text = Strings.titleCalendar;
        }
    }
}
