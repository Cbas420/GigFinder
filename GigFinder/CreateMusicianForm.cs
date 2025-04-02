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
        public CreateMusicianForm()
        {
            InitializeComponent();
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
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            string name = roundedTextBoxName.Texts;
            string email = roundedTextBoxMail.Texts;
            string pass = Entities.Encrypt.EncryptSHA256(roundedTextBoxPass.Texts);
            string confirmPass = Entities.Encrypt.EncryptSHA256(roundedTextBoxConfirmPass.Texts); 
            string description = roundedTextBoxDescription.Texts;
            int lang = customComboBoxLang.SelectedIndex+1;

            bool isPriceValid = int.TryParse(roundedTextBoxPrice.Texts, out int price);
            bool isSizeValid = int.TryParse(roundedTextBoxSizeGroup.Texts, out int size);

            List<Genres> userGenres = listBoxGenres.SelectedItems.Cast<Genres>().ToList();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass) ||
                string.IsNullOrWhiteSpace(confirmPass) ||
                string.IsNullOrWhiteSpace(description) ||
                userGenres.Count == 0 ||
                lang == -1 ||
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
                        _user.password = pass;
                        _user.description = description;
                        _user.type = "music";
                        _user.Genres = userGenres;
                        _user.active = true;
                        UsersOrm.InsertUser(_user);
                        Users _userCreate = UsersOrm.SelectUserWithMail(email);
                        Musicians _music = new Musicians();
                        _music.id = _userCreate.id;
                        _music.price = price;
                        _music.songs_lang = lang;
                        _music.size = (byte)size;
                        UsersOrm.InserMusician(_music);

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
    }
}
