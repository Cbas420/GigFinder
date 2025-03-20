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
            this.StartPosition = FormStartPosition.CenterScreen;
            userLogin = user;
        }

        private void pictureBoxUsers_Click(object sender, EventArgs e)
        {
            if (userLogin.type == "super")
            {
                ManageUsersForm formUsers = new ManageUsersForm();
                formUsers.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                formUsers.Show();
            } else
            {
                MessageBox.Show("No tienes permisos para acceder a este apartado de la aplicación");
            }
        }

        private void labelUsers_Click(object sender, EventArgs e)
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

        private void customPanelUsers_Click(object sender, EventArgs e)
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

        private void pictureBoxData_Click(object sender, EventArgs e)
        {
            ManageDatabaseForm formData = new ManageDatabaseForm();
            formData.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formData.Show();
        }

        private void labelData_Click(object sender, EventArgs e)
        {
            ManageDatabaseForm formData = new ManageDatabaseForm();
            formData.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formData.Show();
        }

        private void customPanelData_Click(object sender, EventArgs e)
        {
            ManageDatabaseForm formData = new ManageDatabaseForm();
            formData.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formData.Show();
        }

        private void pictureBoxStats_Click(object sender, EventArgs e)
        {
            ResumeDataForm formResume = new ResumeDataForm();
            formResume.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formResume.Show();
        }

        private void labelStats_Click(object sender, EventArgs e)
        {
            ResumeDataForm formResume = new ResumeDataForm();
            formResume.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formResume.Show();
        }

        private void customPanelStats_Click(object sender, EventArgs e)
        {
            ResumeDataForm formResume = new ResumeDataForm();
            formResume.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formResume.Show();
        }

        private void pictureBoxRegister_Click(object sender, EventArgs e)
        {
            ActivityRegisterForm formActivity = new ActivityRegisterForm();
            formActivity.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formActivity.Show();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            ActivityRegisterForm formActivity = new ActivityRegisterForm();
            formActivity.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formActivity.Show();
        }

        private void customPanelRegister_Click(object sender, EventArgs e)
        {
            ActivityRegisterForm formActivity = new ActivityRegisterForm();
            formActivity.FormClosed += (s, args) =>
            {
                this.Show();
            };

            formActivity.Show();
        }
    }
}
