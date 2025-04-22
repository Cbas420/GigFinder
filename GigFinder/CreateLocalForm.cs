using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class CreateLocalForm : Form
    {
        private int actionMade;
        private UserLocal _userEdit;
        private string completeFields;
        private string completeFieldsShort;
        private string passCheck;
        private string passCheckShort;
        private string existingLocal;
        private string existingLocalShort;

        public CreateLocalForm(int action, UserLocal user)
        {
            InitializeComponent();
            actionMade = action;
            _userEdit = user;
            bindingSourceGenres.DataSource = GenresOrm.SelectGlobal();  // Populates the genres dropdown
        }

        /// <summary>
        /// Handles the form's Load event. It is triggered when the form is loaded.
        /// </summary>
        private void CreateLocalForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();  // Changes the language of the form
            if (actionMade == 1)  // If editing an existing local, load existing data
            {
                LoadData();
            }
        }

        /// <summary>
        /// Closes the form without saving changes when the cancel button is clicked.
        /// </summary>
        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();  // Closes the form
        }

        /// <summary>
        /// Handles the form submission when the "Create" or "Save" button is clicked.
        /// </summary>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            // Retrieves input values from the form
            string name = roundedTextBoxName.Texts.Trim();
            string email = roundedTextBoxMail.Texts.Trim();
            string pass = roundedTextBoxPass.Texts.Trim();
            string confirmPass = roundedTextBoxConfirmPass.Texts.Trim();
            string description = roundedTextBoxDescription.Texts.Trim();

            bool isCapacityValid = int.TryParse(roundedTextBoxCapacity.Texts.Trim(), out int capacity);
            bool isLatitudeValid = double.TryParse(roundedTextBoxCoordY.Texts.Trim(), out double yCoord);
            bool isLongitudeValid = double.TryParse(roundedTextBoxCoordX.Texts.Trim(), out double xCoord);

            List<Genres> userGenres = listBoxGenres.SelectedItems.Cast<Genres>().ToList();  // Retrieves selected genres

            if (actionMade == 0)  // Creating a new local
            {
                if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass) ||
                string.IsNullOrWhiteSpace(confirmPass) ||
                string.IsNullOrWhiteSpace(description) ||
                userGenres.Count == 0 ||
                !isLatitudeValid || yCoord == null ||
                !isLongitudeValid || xCoord == null)
                {
                    MessageBox.Show(completeFields, completeFieldsShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Show warning for incomplete fields
                }
                else
                {
                    // Check if email already exists
                    Users userMail = UsersOrm.SelectUserWithMail(email);
                    if (userMail == null)
                    {
                        if (pass.Equals(confirmPass))
                        {
                            // Create new user and local
                            Users _user = new Users
                            {
                                name = name,
                                email = email,
                                password = Entities.Encrypt.EncryptSHA256(pass),
                                description = description,
                                type = "local",
                                Genres = userGenres,
                                active = true
                            };
                            UsersOrm.InsertUser(_user);
                            Users _userCreate = UsersOrm.SelectUserWithMail(email);
                            Locals _local = new Locals
                            {
                                id = _userCreate.id,
                                capacity = capacity,
                                x_coordination = xCoord,
                                y_coordination = yCoord
                            };
                            UsersOrm.InsertLocal(_local);

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
                        MessageBox.Show(existingLocal, existingLocalShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Email already exists
                    }
                }
            }
            else  // Editing an existing local
            {
                if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(description) ||
                userGenres.Count == 0 ||
                !isLatitudeValid || yCoord == null ||
                !isLongitudeValid || xCoord == null)
                {
                    MessageBox.Show(completeFields, completeFieldsShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Show warning for incomplete fields
                }
                else
                {
                    // Check if email is already in use by another user
                    Users userToEdit = UsersOrm.SelectUserWithMail(email);
                    if (userToEdit != null && userToEdit.id != _userEdit.id)
                    {
                        MessageBox.Show(existingLocal, existingLocalShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Email already exists
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(pass) && string.IsNullOrEmpty(confirmPass))
                        {
                            // Update user without changing password
                            UsersOrm.UpdateLocalWithoutPass(_userEdit.id, name, email, description, userGenres, capacity, yCoord, xCoord);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            if (pass.Equals(confirmPass))
                            {
                                pass = Entities.Encrypt.EncryptSHA256(pass);  // Encrypt the new password
                                // Update user with new password
                                UsersOrm.UpdateLocal(_userEdit.id, name, email, description, userGenres, capacity, yCoord, xCoord, pass);
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
        /// Loads the data of the existing local user into the form fields for editing.
        /// </summary>
        private void LoadData()
        {
            Users userToEdit = UsersOrm.SelectUserWithMail(_userEdit.email);
            Locals localToEdit = UsersOrm.SelectLocalWithId(_userEdit.id);
            roundedTextBoxName.Texts = userToEdit.name;
            roundedTextBoxMail.Texts = userToEdit.email;
            roundedTextBoxDescription.Texts = userToEdit.description;
            roundedTextBoxCapacity.Texts = localToEdit.capacity.ToString();
            roundedTextBoxCoordX.Texts = localToEdit.x_coordination.ToString();
            roundedTextBoxCoordY.Texts = localToEdit.y_coordination.ToString();
            listBoxGenres.SetSelected(0, false);
            foreach (Genres _genre in userToEdit.Genres)
            {
                for (int i = 0; i < listBoxGenres.Items.Count; i++)
                {
                    if (((Genres)listBoxGenres.Items[i]).id == _genre.id)
                    {
                        listBoxGenres.SetSelected(i, true);  // Select the genres for the user
                    }
                }
            }
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
                labelTitle.Text = Strings.labelCreateLocal;
            }
            else
            {
                labelTitle.Text = Strings.labelEditLocal;
            }

            // Update other UI elements with the appropriate text strings
            roundedButtonCreate.Text = Strings.buttonSave;
            roundedButtonCancel.Text = Strings.buttonCancelar;
            labelPass.Text = Strings.labelPass;
            labelConfirmPass.Text = Strings.labelConfirPass;
            labelDescription.Text = Strings.labelDescription;
            labelGenres.Text = Strings.labelGendres;
            labelMail.Text = Strings.labelMail;
            labelName.Text = Strings.labelName;
            labelCapacity.Text = Strings.labelLocalCapacity;
            labelCoordX.Text = Strings.labelCoordX;
            labelCoordY.Text = Strings.labelCoordY;

            // Store the localized warning messages
            completeFields = Strings.messageComplete;
            completeFieldsShort = Strings.messageCompleteShort;
            passCheck = Strings.messagePassCheck;
            passCheckShort = Strings.messagePassCheckShort;
            existingLocal = Strings.existingLocal;
            existingLocalShort = Strings.existingLocalShort;
        }
    }
}
