using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Entities;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class CreateUserForm : Form
    {
        int actionMade;
        UsersDesktop _userEdit;
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
            _userEdit = user;
        }
        

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            if (actionMade == 1)
            {
                roundedTextBoxName.Texts = _userEdit.name;
                roundedTextBoxSurname.Texts = _userEdit.surname;
                roundedTextBoxMail.Texts = _userEdit.email;
                customComboBoxType.SelectedItem = _userEdit.type;
                customComboBoxType.Texts = _userEdit.type.ToString();
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

            
            if (actionMade == 0)
            {
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
                    UsersDesktop userMail = UsersDesktopOrm.SelectWithMail(email);
                    if (userMail == null)
                    {
                        if (password.Equals(confirmPassword))
                        {
                            UsersDesktop _userDesktop = new UsersDesktop();
                            _userDesktop.name = name;
                            _userDesktop.surname = surname;
                            _userDesktop.email = email;
                            _userDesktop.password = Encrypt.EncryptSHA256(password);
                            _userDesktop.type = type;

                            UsersDesktopOrm.Insert(_userDesktop);
                            this.DialogResult = DialogResult.OK;
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
            }
            else
            {
                if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(type))
                {
                    MessageBox.Show(complete, completeShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else
                {
                    UsersDesktop userToEdit = UsersDesktopOrm.SelectWithMail(email);
                    if (userToEdit != null && userToEdit.id != _userEdit.id)
                    {
                        MessageBox.Show(userExists, userExistsShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(confirmPassword))
                        {
                            _userEdit.name = name;
                            _userEdit.surname = surname;
                            _userEdit.email = email;
                            _userEdit.type = type;

                            UsersDesktopOrm.UpdateWithoutPass(_userEdit);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        } 
                        else
                        {
                            if (password.Equals(confirmPassword))
                            {
                                _userEdit.name = name;
                                _userEdit.surname = surname;
                                _userEdit.email = email;
                                _userEdit.password = Encrypt.EncryptSHA256(password);
                                _userEdit.type = type;

                                UsersDesktopOrm.Update(_userEdit);
                                this.DialogResult = DialogResult.OK;
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
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (actionMade == 0)
            {
                labelTitle.Text = Strings.labelCreateUser;
            }
            else
            {
                labelTitle.Text = Strings.titleEditUser;
            }
            roundedButtonCancel.Text = Strings.buttonCancelar;
            roundedButtonSave.Text = Strings.buttonSave;
            labelMail.Text = Strings.labelMail;
            labelName.Text = Strings.labelName;
            labelConfirmPass.Text = Strings.labelConfirPass;
            labelPass.Text = Strings.labelPass;
            labelSurname.Text = Strings.labelSurname;
            customComboBoxType.Texts = Strings.comboBoxUserType;
            complete = Strings.messageComplete;
            completeShort = Strings.messageCompleteShort;
            passCheck = Strings.messagePassCheck;
            passCheckShort = Strings.messagePassCheckShort;
            userExists = Strings.messageUserExists;
            userExistsShort = Strings.messageUserExistsShort;
        }
    }
}
