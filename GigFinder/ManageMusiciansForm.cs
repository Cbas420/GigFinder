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
        string editMusician;
        string editMusicianShort;
        string musicianDelete;
        string musicianDeleteShort;
        string askMusicianDelete;
        string askMusicianDeleteShort;
        string accesFunction;
        string accesFunctionShort;
        public ManageMusiciansForm(UsersDesktop user)
        {
            InitializeComponent();
            bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
            _userLogin = user;
        }

        /// <summary>
        /// Handles the form load event. Applies the language configuration.
        /// </summary>
        private void ManageMusiciansForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the create button click. Opens the musician creation form.
        /// </summary>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "user")
            {
                CreateMusicianForm createMusician = new CreateMusicianForm(0, _userEdit);
                if (createMusician.ShowDialog() == DialogResult.OK)
                {
                    // Refresh musician list after creation
                    bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
                    Log.createLog("Create Musician", _userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                // Show permission warning
                MessageBox.Show(accesFunction, accesFunctionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the delete button click. Prompts user to confirm musician deletion.
        /// </summary>
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

                        // Refresh list after deletion
                        bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
                        customComboBoxOrder.Texts = Strings.comboBoxOrder;
                    }
                }
                else
                {
                    // Prompt user to select a musician before deleting
                    MessageBox.Show(musicianDelete, musicianDeleteShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Show permission warning
                MessageBox.Show(accesFunction, accesFunctionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the change event of the combo box used for ordering musicians.
        /// </summary>
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();
            var orderedMusicians = OrderMusiciansBy(selectedOrder);
            bindingSourceMusician.DataSource = orderedMusicians;
        }

        /// <summary>
        /// Handles the edit button click. Opens the form to edit a selected musician.
        /// </summary>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                _userEdit = (UserMusician)dataGridViewData.SelectedRows[0].DataBoundItem;
                CreateMusicianForm createMusicianForm = new CreateMusicianForm(1, _userEdit);
                if (createMusicianForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh list after edit
                    bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
                    Log.createLog("Edit Musician", _userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                // Prompt user to select a musician before editing
                MessageBox.Show(editMusician, editMusicianShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Orders the list of musicians by the specified field.
        /// </summary>
        /// <param name="selectedOrder">The field to sort by (e.g. "Name", "Email").</param>
        /// <returns>A sorted list of <see cref="UserMusician"/> objects.</returns>
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