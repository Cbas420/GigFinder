using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigFinder.Controls;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class CreateLocalForm : Form
    {
        int actionMade;
        UserLocal _userEdit;
        public CreateLocalForm(int action, UserLocal user)
        {
            InitializeComponent();
            actionMade = action;
            _userEdit = user;
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
            LoadData();
        }

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
                        listBoxGenres.SetSelected(i, true);
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

            bool isCapacityValid = int.TryParse(roundedTextBoxCapacity.Texts.Trim(), out int capacity);
            bool isLatitudeValid = double.TryParse(roundedTextBoxCoordY.Texts.Trim(), out double yCoord);
            bool isLongitudeValid = double.TryParse(roundedTextBoxCoordX.Texts.Trim(), out double xCoord);

            List<Genres> userGenres = listBoxGenres.SelectedItems.Cast<Genres>().ToList();

            if (actionMade == 0)
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
            else
            {
                if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(description) ||
                userGenres.Count == 0 ||
                !isLatitudeValid || yCoord == null ||
                !isLongitudeValid || xCoord == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos correctamente.");
                }
                else
                {
                    Users userToEdit = UsersOrm.SelectUserWithMail(email);
                    if (userToEdit != null && userToEdit.id != _userEdit.id)
                    {
                        MessageBox.Show("Ya existe otro local con ese mail", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(pass) && string.IsNullOrEmpty(confirmPass))
                        {
                            UsersOrm.UpdateLocalWithoutPass(_userEdit.id, name, email, description, userGenres, capacity, yCoord, xCoord);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            if (pass.Equals(confirmPass))
                            {
                                pass = Entities.Encrypt.EncryptSHA256(pass);
                                UsersOrm.UpdateLocal(_userEdit.id, name, email, description, userGenres, capacity, yCoord, xCoord, pass);
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
