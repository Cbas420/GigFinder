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
    public partial class ManageUsersForm : Form
    {
        UsersDesktop _userEdit = null;
        UsersDesktop _userLogin;
        string askDelete;
        string askDeleteShort;
        string selectionShort;
        string selectionDelete;
        string selectionEdit;
        string sameUserDelete;
        string sameUserDeleteShort;

        public ManageUsersForm(UsersDesktop user)
        {
            InitializeComponent();
            bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
            _userLogin = user;
        }

        /// <summary>
        /// Handles the form's Load event and sets the appropriate language for the UI.
        /// </summary>
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the click event of the delete button. Deletes the selected user after confirmation.
        /// Prevents the deletion of the currently logged-in user.
        /// </summary>
        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Check if the selected user is the logged-in user
                if (_userLogin.Equals((UsersDesktop)dataGridViewUsers.SelectedRows[0].DataBoundItem))
                {
                    MessageBox.Show(sameUserDelete, sameUserDeleteShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show(askDelete, askDeleteShort, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        UsersDesktop userDelete = (UsersDesktop)dataGridViewUsers.SelectedRows[0].DataBoundItem;

                        UsersDesktopOrm.Delete(userDelete);
                        Log.createLog("Delete UserDesktop", _userLogin.id);

                        // Refresh the user list after deletion
                        bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
                        customComboBoxFilter.Texts = Strings.comboBoxFilter;
                        customComboBoxOrder.Texts = Strings.comboBoxOrder;
                    }
                }
            }
            else
            {
                MessageBox.Show(selectionDelete, selectionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the click event of the create button. Opens the CreateUserForm for creating a new user.
        /// Refreshes the user list upon success.
        /// </summary>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm(0, _userEdit);
            if (createUserForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the user list after creating a new user
                bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
                Log.createLog("Create UserDesktop", _userLogin.id);
                customComboBoxFilter.Texts = Strings.comboBoxFilter;
                customComboBoxOrder.Texts = Strings.comboBoxOrder;
            }
        }

        /// <summary>
        /// Handles the click event of the edit button. Opens the CreateUserForm in edit mode for the selected user.
        /// Refreshes the user list upon success.
        /// </summary>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                _userEdit = (UsersDesktop)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                CreateUserForm createUserForm = new CreateUserForm(1, _userEdit);
                if (createUserForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the user list after editing a user
                    bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
                    Log.createLog("Edit UserDesktop", _userLogin.id);
                    customComboBoxFilter.Texts = Strings.comboBoxFilter;
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                MessageBox.Show(selectionEdit, selectionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the selection change event of the filter combo box. Filters the user list based on the selected type.
        /// </summary>
        private void customComboBoxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString().ToLower();

            // Filter users based on the selected type
            var filteredUsers = FilterUsersByType(selectedValue);

            bindingSourceUsers.DataSource = filteredUsers;
        }

        /// <summary>
        /// Handles the selection change event of the order combo box. Orders the user list based on the selected field.
        /// </summary>
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            // Order users based on the selected field
            var orderedUsers = OrderUsersBy(selectedOrder);

            bindingSourceUsers.DataSource = orderedUsers;
        }

        /// <summary>
        /// Orders the list of users based on the selected order criterion.
        /// </summary>
        /// <param name="selectedOrder">The field by which to order the users.</param>
        /// <returns>A list of ordered users.</returns>
        private List<UsersDesktop> OrderUsersBy(string selectedOrder)
        {
            var _desktopUsers = UsersDesktopOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "Id":
                    return _desktopUsers.OrderBy(user => user.id).ToList();
                case "Name":
                    return _desktopUsers.OrderBy(user => user.name).ToList();
                case "Surname":
                    return _desktopUsers.OrderBy(user => user.surname).ToList();
                case "Email":
                    return _desktopUsers.OrderBy(user => user.email).ToList();
                case "Type":
                    return _desktopUsers.OrderBy(user => user.type).ToList();
                default:
                    return _desktopUsers;
            }
        }

        /// <summary>
        /// Filters the list of users based on the selected user type.
        /// </summary>
        /// <param name="selectedType">The user type to filter by.</param>
        /// <returns>A filtered list of users.</returns>
        private List<UsersDesktop> FilterUsersByType(string selectedType)
        {
            var _desktopUsers = UsersDesktopOrm.SelectGlobal();

            // If no filter is selected, return all users
            if (string.IsNullOrEmpty(selectedType) || selectedType == "all")
            {
                return _desktopUsers;
            }
            else
            {
                // Filter users by the selected type
                return _desktopUsers.Where(user => user.type == selectedType).ToList();
            }
        }

        /// <summary>
        /// Changes the application language based on the current setting.
        /// </summary>
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        /// <summary>
        /// Updates all texts in the form to match the current language.
        /// </summary>
        private void UpdateTexts()
        {
            sameUserDelete = Strings.sameUserDelete;
            askDelete = Strings.askDelete;
            askDeleteShort = Strings.askDeleteShort;
            labelTitle.Text = Strings.titleUsers;
            customComboBoxFilter.Texts = Strings.comboBoxFilter;
            customComboBoxOrder.Texts = Strings.comboBoxOrder;
            roundedButtonCreate.Text = Strings.buttonCreate;
            roundedButtonEdit.Text = Strings.buttonEdit;
            roundedButtonDelete.Text = Strings.buttonDelete;
        }

    }
}
