using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        int actionMade;
        UsersDesktop _useredit;
        string passCheck;
        string userExists;
        string complete;
        string passCheckShort;
        string userExistsShort;
        string completeShort;

        public CreateUserForm(int action, UsersDesktop user)
        {
            InitializeComponent();
            actionMade = action;
            _useredit = user;
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
            if (actionMade == 0)
            {
                labelTitle.Text = Resources.Strings.labelCreateUser;
            } else
            {
                labelTitle.Text = Resources.Strings.titleEditUser;
            }
            roundedButtonCancel.Text = Resources.Strings.buttonCancelar;
            roundedButtonSave.Text = Resources.Strings.buttonSave;
            labelMail.Text = Resources.Strings.labelMail;
            labelName.Text = Resources.Strings.labelName;
            labelConfirmPass.Text = Resources.Strings.labelConfirPass;
            labelPass.Text = Resources.Strings.labelPass;
            labelSurname.Text = Resources.Strings.labelSurname;
            customComboBoxType.Texts = Resources.Strings.comboBoxUserType;
            complete = Resources.Strings.messageComplete;
            completeShort = Resources.Strings.messageCompleteShort;
            passCheck = Resources.Strings.messagePassCheck;
            passCheckShort = Resources.Strings.messagePassCheckShort;
            userExists = Resources.Strings.messageUserExists;
            userExistsShort = Resources.Strings.messageUserExistsShort;
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
            if (actionMade == 1)
            {
                roundedTextBoxName.Texts = _useredit.name;
                roundedTextBoxSurname.Texts = _useredit.surname;
                roundedTextBoxPass.Texts = _useredit.password;
                roundedTextBoxMail.Texts = _useredit.email;
                roundedTextBoxConfirmPass.Texts = _useredit.password;
                customComboBoxType.SelectedItem = _useredit.type;
                customComboBoxType.Texts = _useredit.type.ToString();
            }
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
                MessageBox.Show(complete, completeShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (actionMade == 0)
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
                            MessageBox.Show(passCheck, passCheckShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(userExists, userExistsShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    UsersDesktop userToEdit = UsersDesktopOrm.SelectWithMail(email);
                    if (userToEdit != null && userToEdit.id != _useredit.id)
                    {
                        MessageBox.Show(userExists, userExistsShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (password.Equals(confirmPassword))
                        {
                            _useredit.name = name;
                            _useredit.surname = surname;
                            _useredit.email = email;
                            _useredit.password = password;
                            _useredit.type = type;

                            clearInfo();
                            UsersDesktopOrm.Update(_useredit);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(passCheck, passCheckShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
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
