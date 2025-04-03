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

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
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
                        deleteRelatedData(userDelete);

                        UsersDesktopOrm.Delete(userDelete);
                        Log.createLog("Delete UserDesktop", _userLogin.id);

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

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm(0, _userEdit);
            if (createUserForm.ShowDialog() == DialogResult.OK)
            {
                bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
                Log.createLog("Create UserDesktop", _userLogin.id);
                customComboBoxFilter.Texts = Strings.comboBoxFilter;
                customComboBoxOrder.Texts = Strings.comboBoxOrder;
            }
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                _userEdit = (UsersDesktop)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                CreateUserForm createUserForm = new CreateUserForm(1, _userEdit);
                if (createUserForm.ShowDialog() == DialogResult.OK)
                {
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

        private void customComboBoxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString().ToLower();

            var filteredUsers = FilterUsersByType(selectedValue);

            bindingSourceUsers.DataSource = filteredUsers;
        }    

        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedUsers = OrderUsersBy(selectedOrder);

            bindingSourceUsers.DataSource = orderedUsers;
        }

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

        private List<UsersDesktop> FilterUsersByType(string selectedType)
        {
            var _desktopUsers = UsersDesktopOrm.SelectGlobal();

            if (string.IsNullOrEmpty(selectedType) || selectedType == "all")
            {
                return _desktopUsers;
            }
            else
            {
                return _desktopUsers.Where(user => user.type == selectedType).ToList();
            }
        }

        private void deleteRelatedData(UsersDesktop userDelete)
        {
            List<Activity_log> activity_logs = Activity_logOrm.SelectByUser(userDelete.id);
            foreach (Activity_log activity in activity_logs)
            {
                Activity_logOrm.Delete(activity);
            }
            List<Incidences> incidences = IncidenciesOrm.SelectIncidenceByAdmin(userDelete.id);
            foreach (Incidences incidence in incidences)
            {
                IncidenciesOrm.UpdateIncidenceAdmin(userDelete.id);
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
