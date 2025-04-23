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
    public partial class CreateMusicianForm : Form
    {
        private int actionMade;
        private UserMusician _userEdit;
        private string completeFields;
        private string completeFieldsShort;
        private string passCheck;
        private string passCheckShort;
        private string existingMusician;
        private string existingMusicianShort;

        public CreateMusicianForm(int action, UserMusician user)
        {
            InitializeComponent();
            actionMade = action;
            _userEdit = user;
            bindingSourceGenres.DataSource = GenresOrm.SelectGlobal();  // Populates the genres dropdown
            bindingSourceLang.DataSource = LanguagesOrm.SelectGlobal();  // Populates the languages dropdown
        }

        /// <summary>
        /// Handles the form's Load event. It is triggered when the form is loaded.
        /// </summary>
        private void CreateMusicianForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();  // Changes the language of the form
            if (actionMade == 1)  // If editing an existing musician, load existing data
            {
                LoadData();
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
            Languages lang = (Languages)customComboBoxLang.SelectedItem;

            bool isPriceValid = int.TryParse(roundedTextBoxPrice.Texts.Trim(), out int price);
            bool isSizeValid = int.TryParse(roundedTextBoxSizeGroup.Texts.Trim(), out int size);

            List<Genres> userGenres = listBoxGenres.SelectedItems.Cast<Genres>().ToList();  // Retrieves selected genres

            if (actionMade == 0)  // Creating a new musician
            {
                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(pass) ||
                    string.IsNullOrWhiteSpace(confirmPass) ||
                    string.IsNullOrWhiteSpace(description) ||
                    userGenres.Count == 0 ||
                    lang == null ||
                    !isPriceValid || price <= 0 ||
                    !isSizeValid || size <= 0)
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
                            // Create new user and musician
                            Users _user = new Users
                            {
                                name = name,
                                email = email,
                                password = Entities.Encrypt.EncryptSHA256(pass),
                                description = description,
                                type = "music",
                                Genres = userGenres,
                                active = true
                            };
                            UsersOrm.InsertUser(_user);
                            Users _userCreate = UsersOrm.SelectUserWithMail(email);
                            Musicians _music = new Musicians
                            {
                                id = _userCreate.id,
                                price = price,
                                songs_lang = lang.id,
                                size = (byte)size
                            };
                            UsersOrm.InsertMusician(_music);

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
                        MessageBox.Show(existingMusician, existingMusicianShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Email already exists
                    }
                }
            }
            else  // Editing an existing musician
            {
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(description) ||
                    userGenres.Count == 0 ||
                    lang == null ||
                    !isPriceValid || price <= 0 ||
                    !isSizeValid || size <= 0)
                {
                    MessageBox.Show(completeFields, completeFieldsShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Show warning for incomplete fields
                }
                else
                {
                    // Check if email is already in use by another user
                    Users userToEdit = UsersOrm.SelectUserWithMail(email);
                    if (userToEdit != null && userToEdit.id != _userEdit.id)
                    {
                        MessageBox.Show(existingMusician, existingMusicianShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Email already exists
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(pass) && string.IsNullOrEmpty(confirmPass))
                        {
                            // Update user without changing password
                            UsersOrm.UpdateMusicianWithoutPass(_userEdit.id, name, email, description, userGenres, lang, price, size);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            if (pass.Equals(confirmPass))
                            {
                                pass = Entities.Encrypt.EncryptSHA256(pass);  // Encrypt the new password
                                // Update user with new password
                                UsersOrm.UpdateMusician(_userEdit.id, name, email, description, userGenres, lang, price, size, pass);
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
        /// Loads the data of the existing musician user into the form fields for editing.
        /// </summary>
        private void LoadData()
        {
            Users userToEdit = UsersOrm.SelectUserWithMail(_userEdit.email);
            Musicians musicianToEdit = UsersOrm.SelectMusicianWithId(_userEdit.id);
            roundedTextBoxName.Texts = userToEdit.name;
            roundedTextBoxMail.Texts = userToEdit.email;
            roundedTextBoxDescription.Texts = userToEdit.description;
            roundedTextBoxPrice.Texts = musicianToEdit.price.ToString();
            roundedTextBoxSizeGroup.Texts = musicianToEdit.size.ToString();
            customComboBoxLang.SelectedItem = _userEdit.lang;
            customComboBoxLang.Texts = _userEdit.lang;
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
            if (actionMade == 0)
            {
                labelTitle.Text = Strings.labelCreateMusic;
            }
            else
            {
                labelTitle.Text = Strings.labelEditMusic;
            }
            roundedButtonCreate.Text = Strings.buttonSave;
            roundedButtonCancel.Text = Strings.buttonCancelar;
            labelPass.Text = Strings.labelPass;
            labelConfirmPass.Text = Strings.labelConfirPass;
            labelDescription.Text = Strings.labelDescription;
            labelGenres.Text = Strings.labelGendres;
            labelMail.Text = Strings.labelMail;
            labelName.Text = Strings.labelName;
            labelPrize.Text = Strings.labelPrice;
            labelGroupSize.Text = Strings.labelGroupSize;
            passCheck = Strings.messagePassCheck;
            passCheckShort = Strings.messagePassCheckShort;
            completeFields = Strings.messageComplete;
            completeFieldsShort = Strings.messageCompleteShort;
            existingMusician = Strings.existingMusician;
            existingMusicianShort = Strings.existingMusicianShort;
        }
    }
}
