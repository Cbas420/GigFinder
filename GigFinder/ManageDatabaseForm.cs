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
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        private void UpdateTexts()
        {            
        }

        private void ManageDatabaseForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void customPanelMusicians_Click(object sender, EventArgs e)
        {
            menuMusicians();
        }

        private void pictureBoxMusicians_Click(object sender, EventArgs e)
        {
            menuMusicians();
        }

        private void labelMusicians_Click(object sender, EventArgs e)
        {
            menuMusicians();
        }

        private void customPanelLocals_Click(object sender, EventArgs e)
        {
            menuLocals();
        }

        private void pictureBoxLocals_Click(object sender, EventArgs e)
        {
            menuLocals();
        }

        private void labelLocals_Click(object sender, EventArgs e)
        {
            menuLocals();
        }

        private void customPanelIncidencies_Click(object sender, EventArgs e)
        {
            menuIncidencies();
        }

        private void pictureBoxIncidencies_Click(object sender, EventArgs e)
        {
            menuIncidencies();
        }

        private void labelIncidencies_Click(object sender, EventArgs e)
        {
            menuIncidencies();
        }

        private void customPanelRatings_Click(object sender, EventArgs e)
        {
            menuRatings();
        }

        private void pictureBoxRatings_Click(object sender, EventArgs e)
        {
            menuRatings();
        }

        private void labelRatings_Click(object sender, EventArgs e)
        {
            menuRatings();
        }
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
    }
}
