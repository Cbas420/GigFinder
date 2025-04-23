using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ManageDatabaseForm : Form
    {
        UsersDesktop userLogin;
        public ManageDatabaseForm(UsersDesktop user)
        {
            InitializeComponent();
            userLogin = user;
        }

        /// <summary>
        /// Handles the form load event and sets the UI language.
        /// </summary>
        private void ManageDatabaseForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Opens the musicians management form when the panel is clicked.
        /// </summary>
        private void customPanelMusicians_Click(object sender, EventArgs e)
        {
            menuMusicians();
        }

        /// <summary>
        /// Opens the musicians management form when the picture box is clicked.
        /// </summary>
        private void pictureBoxMusicians_Click(object sender, EventArgs e)
        {
            menuMusicians();
        }

        /// <summary>
        /// Opens the musicians management form when the label is clicked.
        /// </summary>
        private void labelMusicians_Click(object sender, EventArgs e)
        {
            menuMusicians();
        }

        /// <summary>
        /// Opens the locals management form when the panel is clicked.
        /// </summary>
        private void customPanelLocals_Click(object sender, EventArgs e)
        {
            menuLocals();
        }

        /// <summary>
        /// Opens the locals management form when the picture box is clicked.
        /// </summary>
        private void pictureBoxLocals_Click(object sender, EventArgs e)
        {
            menuLocals();
        }

        /// <summary>
        /// Opens the locals management form when the label is clicked.
        /// </summary>
        private void labelLocals_Click(object sender, EventArgs e)
        {
            menuLocals();
        }

        /// <summary>
        /// Opens the incidences management form when the panel is clicked.
        /// </summary>
        private void customPanelIncidencies_Click(object sender, EventArgs e)
        {
            menuIncidencies();
        }

        /// <summary>
        /// Opens the incidences management form when the picture box is clicked.
        /// </summary>
        private void pictureBoxIncidencies_Click(object sender, EventArgs e)
        {
            menuIncidencies();
        }

        /// <summary>
        /// Opens the incidences management form when the label is clicked.
        /// </summary>
        private void labelIncidencies_Click(object sender, EventArgs e)
        {
            menuIncidencies();
        }

        /// <summary>
        /// Opens the ratings management form when the panel is clicked.
        /// </summary>
        private void customPanelRatings_Click(object sender, EventArgs e)
        {
            menuRatings();
        }

        /// <summary>
        /// Opens the ratings management form when the picture box is clicked.
        /// </summary>
        private void pictureBoxRatings_Click(object sender, EventArgs e)
        {
            menuRatings();
        }

        /// <summary>
        /// Opens the ratings management form when the label is clicked.
        /// </summary>
        private void labelRatings_Click(object sender, EventArgs e)
        {
            menuRatings();
        }

        /// <summary>
        /// Opens the musician management form and hides the current form until it is closed.
        /// </summary>
        public void menuMusicians()
        {
            ManageMusiciansForm formMusicians = new ManageMusiciansForm(userLogin);
            this.Hide();
            formMusicians.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formMusicians.Show();
        }

        /// <summary>
        /// Opens the local management form and hides the current form until it is closed.
        /// </summary>
        public void menuLocals()
        {
            ManageLocalForm formLocals = new ManageLocalForm(userLogin);
            this.Hide();
            formLocals.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formLocals.Show();
        }

        /// <summary>
        /// Opens the ratings management form and hides the current form until it is closed.
        /// </summary>
        public void menuRatings()
        {
            ManageRatingsForm formRatings = new ManageRatingsForm(userLogin);
            this.Hide();
            formRatings.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formRatings.Show();
        }

        /// <summary>
        /// Opens the incidences management form and hides the current form until it is closed.
        /// </summary>
        public void menuIncidencies()
        {
            ManageIncidencesForm formIncidencies = new ManageIncidencesForm(userLogin);
            this.Hide();
            formIncidencies.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formIncidencies.Show();
        }

        /// <summary>
        /// Changes the current thread's culture and UI culture based on the selected language.
        /// </summary>
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            UpdateTexts(); // Refresh UI labels with new language
        }

        /// <summary>
        /// Updates UI labels with localized resource strings.
        /// </summary>
        private void UpdateTexts()
        {
            labelIncidencies.Text = Strings.incidenciesManage;
            labelLocals.Text = Strings.LocalsManage;
            labelMusicians.Text = Strings.musiciansManage;
            labelRatings.Text = Strings.ratingsManage;
        }
    }
}
