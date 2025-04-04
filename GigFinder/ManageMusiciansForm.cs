using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Entities;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ManageMusiciansForm : Form
    {
        UserMusician _userEdit = null;
        UsersDesktop _userLogin;
        String editMusician;
        String editMusicianShort;
        String musicianDelete;
        String musicianDeleteShort;
        String askMusicianDelete;
        String askMusicianDeleteShort;
        String accesFunction;
        String accesFunctionShort;

        public ManageMusiciansForm(UsersDesktop user)
        {
            InitializeComponent();
            bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
            _userLogin = user;
        }

        private void ManageMusiciansForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "user")
            {
                CreateMusicianForm createMusician = new CreateMusicianForm(0, _userEdit);
                if (createMusician.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
                    Log.createLog("Create Musician", _userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            } 
            else
            {
                MessageBox.Show(accesFunction, accesFunctionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "user")
            {
                if (dataGridViewData.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show(askMusicianDelete, askMusicianDeleteShort, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        UserMusician userDelete = (UserMusician)dataGridViewData.SelectedRows[0].DataBoundItem;

                        UsersOrm.DeleteUserMusician(userDelete);
                        Log.createLog("Delete Musician", _userLogin.id);
                        bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();

                        customComboBoxOrder.Texts = Strings.comboBoxOrder;
                    }
                }
                else
                {
                    MessageBox.Show(musicianDelete, musicianDeleteShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(accesFunction, accesFunctionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedMusicians = OrderMusiciansBy(selectedOrder);

            bindingSourceMusician.DataSource = orderedMusicians;
        }  

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                _userEdit = (UserMusician)dataGridViewData.SelectedRows[0].DataBoundItem;
                CreateMusicianForm createMusicianForm = new CreateMusicianForm(1, _userEdit);
                if (createMusicianForm.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
                    Log.createLog("Edit Musician", _userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                MessageBox.Show(editMusician, editMusicianShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private List<UserMusician> OrderMusiciansBy(string selectedOrder)
        {
            var _musicians = UsersOrm.SelectMusicians();

            switch (selectedOrder)
            {
                case "Id":
                    return _musicians.OrderBy(user => user.id).ToList();

                case "Name":
                    return _musicians.OrderBy(user => user.name).ToList();

                case "Email":
                    return _musicians.OrderBy(user => user.email).ToList();

                case "Size":
                    return _musicians.OrderBy(user => user.size).ToList();

                case "Price":
                    return _musicians.OrderBy(user => user.price).ToList();

                case "Lang":
                    return _musicians.OrderBy(user => user.lang).ToList();

                default:
                    return _musicians;
            }
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
            roundedButtonCreate.Text = Strings.buttonCreate;
            roundedButtonDelete.Text = Strings.buttonDelete;
            roundedButtonEdit.Text = Strings.buttonEdit;
            customComboBoxOrder.Texts = Strings.comboBoxOrder;
            labelTitle.Text = Strings.titleMusicians;
            editMusician = Strings.editMusician;
            editMusicianShort = Strings.selectionShort;
            musicianDelete = Strings.musicianDelete;
            musicianDeleteShort = Strings.selectionShort;
            askMusicianDelete = Strings.askMusicianDelete;
            askMusicianDeleteShort = Strings.askDeleteShort;
            accesFunction = Strings.accesFunction;
            accesFunctionShort = Strings.accesMenuShort;
        }
    }
}


    
