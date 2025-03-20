using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigFinder.Models;

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
                ManageUsersForm formUsers = new ManageUsersForm();
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
            ManageDatabaseForm formData = new ManageDatabaseForm();
            formData.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formData.Show();
        }

        public void menuStats()
        {
            ResumeDataForm formResume = new ResumeDataForm();
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
    }
}