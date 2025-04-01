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
        UsersDesktop userLogin;
        public SelectAccessForm(UsersDesktop user)
        {
            InitializeComponent();
            userLogin = user;
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
            if (userLogin.type == "super")
            {
                ManageUsersForm formUsers = new ManageUsersForm(userLogin);
                this.Hide();
                formUsers.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                formUsers.Show();
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación");
            }
        }

        public void menuData()
        {
            ManageDatabaseForm formData = new ManageDatabaseForm(userLogin);
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
            if (userLogin.type == "super")
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
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación");
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
        }

        private void SelectAccessForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }
    }
}