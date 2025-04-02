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
    public partial class CreateLocalForm : Form
    {
        public CreateLocalForm()
        {
            InitializeComponent();
            bindingSourceGenres.DataSource = GenresOrm.SelectGlobal();
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
            labelTitle.Text = Strings.labelCreateLocal;
            roundedButtonCreate.Text = Strings.buttonSave;
            roundedButtonCancel.Text = Strings.buttonCancelar;
            labelConfirmPass.Text = Strings.labelConfirPass;
            labelDescription.Text = Strings.labelDescription;
            labelGenres.Text = Strings.labelGendres;
            labelMail.Text = Strings.labelMail;
            labelName.Text = Strings.labelName;
            labelPass.Text = Strings.labelPass;
            labelCapacity.Text = Strings.labelLocalCapacity;
            labelCoordX.Text = Strings.labelCoordX;
            labelCoordY.Text = Strings.labelCoordY;
        }

        private void CreateLocalForm_Load(object sender, EventArgs e)
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

            bool isCapacityValid = int.TryParse(roundedTextBoxCapacity.Texts, out int capacity);
            bool isLatitudeValid = double.TryParse(roundedTextBoxCoordY.Texts, out double yCoord);
            bool isLongitudeValid = double.TryParse(roundedTextBoxCoordX.Texts, out double xCoord);

            List<Genres> userGenres = listBoxGenres.SelectedItems.Cast<Genres>().ToList();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass) ||
                string.IsNullOrWhiteSpace(confirmPass) ||
                string.IsNullOrWhiteSpace(description) ||
                userGenres.Count == 0 ||
                !isLatitudeValid || yCoord <= 0 ||
                !isLongitudeValid || xCoord <= 0)
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
                        _user.type = "local";
                        _user.Genres = userGenres;
                        _user.active = true;
                        UsersOrm.InsertUser(_user);
                        Users _userCreate = UsersOrm.SelectUserWithMail(email);
                        Locals _local = new Locals();
                        _local.id = _userCreate.id;
                        _local.capacity = capacity;
                        _local.x_coordination = xCoord;
                        _local.y_coordination = yCoord;
                        UsersOrm.InsertLocal(_local);

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
