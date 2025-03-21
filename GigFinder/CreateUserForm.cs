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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void CambiarIdioma()
        {
            CultureInfo cultura = new CultureInfo(LanguageManager.Idioma);
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;
            ActualizarTextos();
        }

        private void ActualizarTextos()
        {
            labelTitle.Text = Resources.Strings.labelCreateUser;
            labelMail.Text = Resources.Strings.labelMail;
            labelName.Text = Resources.Strings.labelName;
            labelConfirmPass.Text = Resources.Strings.labelConfirPass;
            labelPass.Text = Resources.Strings.labelPass;
            labelSurname.Text = Resources.Strings.labelSurname;
            customComboBoxType.Texts = Resources.Strings.comboBoxUserType;
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts.Trim();
            string surname = roundedTextBoxSurname.Texts.Trim();
            string email = roundedTextBoxMail.Texts.Trim();
            string password = roundedTextBoxPass.Texts.Trim();
            string confirmPassword = roundedTextBoxConfirmPass.Texts.Trim();
            string type = customComboBoxType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                UsersDesktop userMail = UsersDesktopOrm.SelectWithMail(email);
                if (userMail == null)
                {
                    if (password.Equals(confirmPassword))
                    {
                        UsersDesktop _userDesktop = new UsersDesktop();
                        _userDesktop.name = name;
                        _userDesktop.surname = surname;
                        _userDesktop.email = email;
                        _userDesktop.password = password;
                        _userDesktop.type = type;

                        clearInfo();
                        UsersDesktopOrm.Insert(_userDesktop);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Contraseñas erróneas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    MessageBox.Show("ya existe un usuario con ese email.", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }            
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            clearInfo();
            this.Close();
        }

        private void clearInfo()
        {
            customComboBoxType.Texts = Resources.Strings.comboBoxUserType;
            roundedTextBoxConfirmPass.Texts = "";
            roundedTextBoxPass.Texts = "";
            roundedTextBoxName.Texts = "";
            roundedTextBoxSurname.Texts = "";
            roundedTextBoxMail.Texts = "";
        }
    }
}
