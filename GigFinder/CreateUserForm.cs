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

        /// <summary>
        /// Handles the form's Load event. It is triggered when the form is loaded.
        /// </summary>
        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();  // Changes the language of the form
            if (actionMade == 1)  // If editing an existing user, load existing data
            {
                roundedTextBoxName.Texts = _userEdit.name;
                roundedTextBoxSurname.Texts = _userEdit.surname;
                roundedTextBoxMail.Texts = _userEdit.email;
                customComboBoxType.SelectedItem = _userEdit.type;
                customComboBoxType.Texts = _userEdit.type.ToString();
            }
        }

        /// <summary>
        /// Handles the form submission when the "Create" or "Save" button is clicked.
        /// </summary>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            // Retrieves input values from the form
            string name = roundedTextBoxName.Texts.Trim();
            string surname = roundedTextBoxSurname.Texts.Trim();
            string email = roundedTextBoxMail.Texts.Trim();
            string password = roundedTextBoxPass.Texts.Trim();
            string confirmPassword = roundedTextBoxConfirmPass.Texts.Trim();
            string type = customComboBoxType.SelectedItem?.ToString();

            if (actionMade == 0)  // Creating a new user
            {
                // Validate that no fields are empty
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(surname) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(confirmPassword) ||
                    string.IsNullOrEmpty(type))
                {
                    MessageBox.Show(complete, completeShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Show warning for incomplete fields
                }
                else
                {
                    // Check if email already exists
                    UsersDesktop userMail = UsersDesktopOrm.SelectWithMail(email);
                    if (userMail == null)
                    {
                        if (password.Equals(confirmPassword))
                        {
                            // Create new user
                            UsersDesktop _userDesktop = new UsersDesktop
                            {
                                name = name,
                                surname = surname,
                                email = email,
                                password = Encrypt.EncryptSHA256(password),
                                type = type
                            };

                            UsersDesktopOrm.Insert(_userDesktop);
                            this.DialogResult = DialogResult.OK;  // Signals successful creation
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(passCheck, passCheckShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Passwords do not match
                        }
                    }
                    else
                    {
                        MessageBox.Show(userExists, userExistsShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Email already exists
                    }
                }
            }
            else  // Editing an existing user
            {
                // Validate that required fields are filled
                if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(type))
                {
                    MessageBox.Show(complete, completeShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Show warning for incomplete fields
                }
                else
                {
                    // Check if email is already in use by another user
                    UsersDesktop userToEdit = UsersDesktopOrm.SelectWithMail(email);
                    if (userToEdit != null && userToEdit.id != _userEdit.id)
                    {
                        MessageBox.Show(userExists, userExistsShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Email already exists
                    }
                    else
                    {
                        // Update user without changing password
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
                            // If passwords are provided, validate and update user with new password
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
                                MessageBox.Show(passCheck, passCheckShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Passwords do not match
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Closes the form when the cancel button is clicked without saving any changes.
        /// </summary>
        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();  // Closes the form
        }

        /// <summary>
        /// Changes the language of the form based on the selected language in the language manager.
        /// </summary>
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();  // Updates UI text according to the new language
        }

        /// <summary>
        /// Updates the UI text elements based on the current language.
        /// </summary>
        private void UpdateTexts()
        {
            if (actionMade == 0)
            {
                labelTitle.Text = Strings.labelCreateUser;  // Set title for creating a new user
            }
            else
            {
                labelTitle.Text = Strings.titleEditUser;  // Set title for editing an existing user
            }

            // Update other UI elements with the appropriate text strings
            roundedButtonCancel.Text = Strings.buttonCancelar;
            roundedButtonSave.Text = Strings.buttonSave;
            labelMail.Text = Strings.labelMail;
            labelName.Text = Strings.labelName;
            labelConfirmPass.Text = Strings.labelConfirPass;
            labelPass.Text = Strings.labelPass;
            labelSurname.Text = Strings.labelSurname;
            customComboBoxType.Texts = Strings.comboBoxUserType;

            // Store the localized warning messages
            complete = Strings.messageComplete;
            completeShort = Strings.messageCompleteShort;
            passCheck = Strings.messagePassCheck;
            passCheckShort = Strings.messagePassCheckShort;
            userExists = Strings.messageUserExists;
            userExistsShort = Strings.messageUserExistsShort;
        }
    }
}
