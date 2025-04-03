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

        private void pictureBoxUsers_Click(object sender, EventArgs e)
        {
            menuUsers();
        }

        private void labelUsers_Click(object sender, EventArgs e)
        {
            menuUsers();
        }

        private void customPanelUsers_Click(object sender, EventArgs e)
        {
            menuUsers();
        }

        private void pictureBoxData_Click(object sender, EventArgs e)
        {
            menuData();
        }

        private void labelData_Click(object sender, EventArgs e)
        {
            menuData();
        }

        private void customPanelData_Click(object sender, EventArgs e)
        {
            menuData();
        }

        private void pictureBoxStats_Click(object sender, EventArgs e)
        {
            menuStats();
        }

        private void labelStats_Click(object sender, EventArgs e)
        {
            menuStats();
        }

        private void customPanelStats_Click(object sender, EventArgs e)
        {
            menuStats();
        }

        private void pictureBoxRegister_Click(object sender, EventArgs e)
        {
            menuRegister();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            menuRegister();
        }

        private void customPanelRegister_Click(object sender, EventArgs e)
        {
            menuRegister();
        }

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
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            labelUsers.Text = Strings.menuUsers;
            labelStats.Text = Strings.menuStats;
            labelRegister.Text = Strings.menuActivity;
            labelData.Text = Strings.menuData;
            accesMenu = Strings.accesMenu;
            accesMenuShort = Strings.accesMenuShort;
        }

        private void SelectAccessForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }
    }
}