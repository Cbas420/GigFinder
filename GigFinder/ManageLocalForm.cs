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
    public partial class ManageLocalForm : Form
    {
        UserLocal _userEdit = null;
        UsersDesktop _userLogin;
        string selectionShort;
        string selectionLocalEdit;
        string selectionLocalDelete;
        string accesFunction;
        string accesFunctionShort;
        string askDelete;
        string askDeleteShort;
        public ManageLocalForm(UsersDesktop user)
        {
            InitializeComponent();
            bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
            _userLogin = user;
        }

        /// <summary>
        /// Handles the form load event. Applies the selected UI language.
        /// </summary>
        private void ManageLocalForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the click event for the "Create" button. Opens the create local form.
        /// Only accessible to users with appropriate permissions.
        /// </summary>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "user")
            {
                CreateLocalForm createLocal = new CreateLocalForm(0, _userEdit);
                if (createLocal.ShowDialog() == DialogResult.OK)
                {
                    // Refresh list after creation
                    bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
                    Log.createLog("Create Local", _userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                // Show access restriction warning
                MessageBox.Show(accesFunction, accesFunctionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the click event for the "Delete" button. Deletes the selected local.
        /// Prompts confirmation before proceeding and checks user permissions.
        /// </summary>
        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "user")
            {
                if (dataGridViewLocal.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show(askDelete, askDeleteShort, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        UserLocal userDelete = (UserLocal)dataGridViewLocal.SelectedRows[0].DataBoundItem;

                        UsersOrm.DeleteUserLocal(userDelete);
                        Log.createLog("Delete Local", _userLogin.id);

                        // Refresh the list after deletion
                        bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
                        customComboBoxOrder.Texts = Strings.comboBoxOrder;
                    }
                }
                else
                {
                    // Warn user to select a local before deleting
                    MessageBox.Show(selectionLocalDelete, selectionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Show access restriction warning
                MessageBox.Show(accesFunction, accesFunctionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the event when the order combo box selection changes.
        /// Reorders the list of locals accordingly.
        /// </summary>
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();
            var orderedLocals = OrderLocalsBy(selectedOrder);
            bindingSourceLocal.DataSource = orderedLocals;
        }

        /// <summary>
        /// Handles the click event for the "Edit" button. Opens the edit local form.
        /// </summary>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocal.SelectedRows.Count > 0)
            {
                _userEdit = (UserLocal)dataGridViewLocal.SelectedRows[0].DataBoundItem;

                CreateLocalForm createLocalForm = new CreateLocalForm(1, _userEdit);
                if (createLocalForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh list after editing
                    bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
                    Log.createLog("Edit Local", _userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                // Warn user to select a local before editing
                MessageBox.Show(selectionLocalEdit, selectionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Orders the list of local users based on the selected property.
        /// </summary>
        /// <param name="selectedOrder">The field to sort by (e.g. "Id", "Name").</param>
        /// <returns>A sorted list of <see cref="UserLocal"/> records.</returns>
        private List<UserLocal> OrderLocalsBy(string selectedOrder)
        {
            var _locals = UsersOrm.SelectLocals();

            switch (selectedOrder)
            {
                case "Id":
                    return _locals.OrderBy(user => user.id).ToList();
                case "Name":
                    return _locals.OrderBy(user => user.name).ToList();
                case "Email":
                    return _locals.OrderBy(user => user.email).ToList();
                case "Size":
                    return _locals.OrderBy(user => user.capacity).ToList();
                default:
                    return _locals;
            }
        }

        /// <summary>
        /// Changes the application's language based on the global setting.
        /// </summary>
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        /// <summary>
        /// Updates UI text components using localized string resources.
        /// </summary>
        private void UpdateTexts()
        {
            labelTitle.Text = Strings.titleLocals;
            customComboBoxOrder.Texts = Strings.comboBoxOrder;
            roundedButtonCreate.Text = Strings.buttonCreate;
            roundedButtonDelete.Text = Strings.buttonDelete;
            roundedButtonEdit.Text = Strings.buttonEdit;
            selectionShort = Strings.selectionShort;
            selectionLocalDelete = Strings.selectionLocalDelete;
            selectionLocalEdit = Strings.selectionLocalEdit;
            accesFunction = Strings.accesFunction;
            accesFunctionShort = Strings.accesMenuShort;
            askDelete = Strings.askDelete;
            askDeleteShort = Strings.askDeleteShort;
        }
    }
}
