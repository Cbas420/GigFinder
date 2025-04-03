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
    public partial class CreateMusicianForm : Form
    {
        int actionMade;
        UserMusician _userEdit;
        public CreateMusicianForm(int action, UserMusician user)
        {
            InitializeComponent();
            _userEdit = user;
            actionMade = action;
            bindingSourceGenres.DataSource = GenresOrm.SelectGlobal();
            bindingSourceLang.DataSource = LanguagesOrm.SelectGlobal();
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
            labelTitle.Text = Strings.labelCreateMusic;
            roundedButtonCreate.Text = Strings.buttonSave;
            roundedButtonCancel.Text = Strings.buttonCancelar;
            customComboBoxLang.Texts = Strings.comboBoxLang;
            labelConfirmPass.Text = Strings.labelConfirPass;
            labelDescription.Text = Strings.labelDescription;
            labelGenres.Text = Strings.labelGendres;
            labelGroupSize.Text = Strings.labelGroupSize;
            labelMail.Text = Strings.labelMail;
            labelName.Text = Strings.labelName;
            labelPass.Text = Strings.labelPass;
            labelPrize.Text = Strings.labelPrice;
        }

        private void CreateMusicianForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            LoadData();
            
        }

        private void LoadData()
        {
            if (actionMade == 1)
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
                            listBoxGenres.SetSelected(i, true);
                        }
                    }
                }
            }
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts.Trim();
            string email = roundedTextBoxMail.Texts.Trim();
            string pass = roundedTextBoxPass.Texts.Trim();
            string confirmPass = roundedTextBoxConfirmPass.Texts.Trim();
            string description = roundedTextBoxDescription.Texts.Trim();
            Languages lang = (Languages)customComboBoxLang.SelectedItem;

            bool isPriceValid = int.TryParse(roundedTextBoxPrice.Texts.Trim(), out int price);
            bool isSizeValid = int.TryParse(roundedTextBoxSizeGroup.Texts.Trim(), out int size);

            List<Genres> userGenres = listBoxGenres.SelectedItems.Cast<Genres>().ToList();

            if (actionMade == 0)
            {
                if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(pass) ||
                string.IsNullOrEmpty(confirmPass) ||
                string.IsNullOrEmpty(description) ||
                userGenres.Count == 0 ||
                lang == null ||
                !isPriceValid || price <= 0 ||
                !isSizeValid || size <= 0)
                {
                    MessageBox.Show("Por favor, completa todos los campos correctamente.");
                }
                else
                {
                    Users userMail = UsersOrm.SelectUserWithMail(email);
                    if (userMail == null)
                    {
                        if (pass.Equals(confirmPass))
                        {
                            Users _user = new Users();
                            _user.name = name;
                            _user.email = email;
                            _user.password = Entities.Encrypt.EncryptSHA256(pass);
                            _user.description = description;
                            _user.type = "music";
                            _user.Genres = userGenres;
                            _user.active = true;
                            UsersOrm.InsertUser(_user);
                            Users _userCreate = UsersOrm.SelectUserWithMail(email);
                            Musicians _music = new Musicians();
                            _music.id = _userCreate.id;
                            _music.price = price;
                            _music.songs_lang = lang.id;
                            _music.size = (byte)size;
                            UsersOrm.InsertMusician(_music);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con ese correo.");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(description) ||
                userGenres.Count == 0 ||
                lang == null ||
                !isPriceValid || price <= 0 ||
                !isSizeValid || size <= 0)
                {
                    MessageBox.Show("Por favor, completa todos los campos correctamente.");
                }
                else
                {
                    Users userToEdit = UsersOrm.SelectUserWithMail(email);
                    if (userToEdit != null && userToEdit.id != _userEdit.id)
                    {
                        MessageBox.Show("Ya existe otro músico con ese mail", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(pass) && string.IsNullOrEmpty(confirmPass))
                        {
                            UsersOrm.UpdateMusicianWithoutPass(_userEdit.id, name, email, description, userGenres, lang, price, size);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            if (pass.Equals(confirmPass))
                            {
                                pass = Entities.Encrypt.EncryptSHA256(pass);
                                UsersOrm.UpdateMusician(_userEdit.id, name, email, description, userGenres, lang, price, size, pass);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }
    }
}
