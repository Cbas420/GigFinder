using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class SelectAccessForm : Form
    {
        UsersDesktop _userLogin;
        string accesMenu;
        string accesMenuShort;

        public SelectAccessForm(UsersDesktop user)
        {
            InitializeComponent();
            _userLogin = user;
        }

        /// <summary>
        /// Handles the form's Load event. Changes the language and initializes the form's components.
        /// </summary>
        private void SelectAccessForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the click event on the Users picture box. Navigates to the ManageUsers form if the user has the appropriate access.
        /// </summary>
        private void pictureBoxUsers_Click(object sender, EventArgs e)
        {
            menuUsers();
        }

        /// <summary>
        /// Handles the click event on the Users label. Navigates to the ManageUsers form if the user has the appropriate access.
        /// </summary>
        private void labelUsers_Click(object sender, EventArgs e)
        {
            menuUsers();
        }

        /// <summary>
        /// Handles the click event on the Users panel. Navigates to the ManageUsers form if the user has the appropriate access.
        /// </summary>
        private void customPanelUsers_Click(object sender, EventArgs e)
        {
            menuUsers();
        }

        /// <summary>
        /// Handles the click event on the Data picture box. Navigates to the ManageDatabase form.
        /// </summary>
        private void pictureBoxData_Click(object sender, EventArgs e)
        {
            menuData();
        }

        /// <summary>
        /// Handles the click event on the Data label. Navigates to the ManageDatabase form.
        /// </summary>
        private void labelData_Click(object sender, EventArgs e)
        {
            menuData();
        }

        /// <summary>
        /// Handles the click event on the Data panel. Navigates to the ManageDatabase form.
        /// </summary>
        private void customPanelData_Click(object sender, EventArgs e)
        {
            menuData();
        }

        /// <summary>
        /// Handles the click event on the Stats picture box. Navigates to the ResumeData form.
        /// </summary>
        private void pictureBoxStats_Click(object sender, EventArgs e)
        {
            menuStats();
        }

        /// <summary>
        /// Handles the click event on the Stats label. Navigates to the ResumeData form.
        /// </summary>
        private void labelStats_Click(object sender, EventArgs e)
        {
            menuStats();
        }

        /// <summary>
        /// Handles the click event on the Stats panel. Navigates to the ResumeData form.
        /// </summary>
        private void customPanelStats_Click(object sender, EventArgs e)
        {
            menuStats();
        }

        /// <summary>
        /// Handles the click event on the Register picture box. Navigates to the ActivityRegister form if the user has the appropriate access.
        /// </summary>
        private void pictureBoxRegister_Click(object sender, EventArgs e)
        {
            menuRegister();
        }

        /// <summary>
        /// Handles the click event on the Register label. Navigates to the ActivityRegister form if the user has the appropriate access.
        /// </summary>
        private void labelRegister_Click(object sender, EventArgs e)
        {
            menuRegister();
        }

        /// <summary>
        /// Handles the click event on the Register panel. Navigates to the ActivityRegister form if the user has the appropriate access.
        /// </summary>
        private void customPanelRegister_Click(object sender, EventArgs e)
        {
            menuRegister();
        }

        /// <summary>
        /// Navigates to the ManageUsers form if the user has a "super" type; otherwise, shows a warning message.
        /// </summary>
        public void menuUsers()
        {
            if (_userLogin.type == "super")
            {
                ManageUsersForm formUsers = new ManageUsersForm(_userLogin);
                this.Hide();
                formUsers.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                formUsers.Show();
            }
            else
            {
                MessageBox.Show(accesMenu, accesMenuShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Navigates to the ManageDatabase form and hides the current form. Shows the current form when the ManageDatabase form is closed.
        /// </summary>
        public void menuData()
        {
            ManageDatabaseForm formData = new ManageDatabaseForm(_userLogin);
            this.Hide();
            formData.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formData.Show();
        }

        /// <summary>
        /// Navigates to the ResumeData form and hides the current form. Shows the current form when the ResumeData form is closed.
        /// </summary>
        public void menuStats()
        {
            ResumeDataForm formResume = new ResumeDataForm();
            this.Hide();
            formResume.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formResume.Show();
        }

        /// <summary>
        /// Navigates to the ActivityRegister form if the user has a "super" type; otherwise, shows a warning message.
        /// </summary>
        public void menuRegister()
        {
            if (_userLogin.type == "super")
            {
                ActivityRegisterForm formActivity = new ActivityRegisterForm();
                this.Hide();
                formActivity.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                formActivity.Show();
            }
            else
            {
                MessageBox.Show(accesMenu, accesMenuShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Changes the language based on the current language setting.
        /// </summary>
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        /// <summary>
        /// Updates the text values on the form according to the current language setting.
        /// </summary>
        private void UpdateTexts()
        {
            labelUsers.Text = Strings.menuUsers;
            labelStats.Text = Strings.menuStats;
            labelRegister.Text = Strings.menuActivity;
            labelData.Text = Strings.menuData;
            accesMenu = Strings.accesMenu;
            accesMenuShort = Strings.accesMenuShort;
        }

    }
}