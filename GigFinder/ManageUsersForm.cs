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
    public partial class ManageUsersForm : Form
    {
        UsersDesktop userEdit = null;
        string askDelete;
        string askDeleteShort;
        string selectionShort;
        string selectionDelete;
        string selectionEdit;
        public ManageUsersForm()
        {
            InitializeComponent();
            bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
        }
        private void CambiarIdioma()
        {
            CultureInfo cultura = new CultureInfo(LanguageManager.Idioma);
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;
            ActualizarTextos();
        }

        private void ActualizarTextos()
        {
            askDelete = Strings.askDelete;
            askDeleteShort = Strings.askDeleteShort;
            labelTitle.Text = Strings.titleUsers;
            customComboBoxFilter.Texts = Strings.comboBoxFilter;
            customComboBoxOrder.Texts = Strings.comboBoxOrder;
            roundedButtonCreate.Text = Strings.buttonCreate;
            roundedButtonEdit.Text = Strings.buttonEdit;
            roundedButtonDelete.Text = Strings.buttonDelete;
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
        }

        private void customComboBoxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString().ToLower();

            var filteredUsers = FilterUsersByType(selectedValue);

            bindingSourceUsers.DataSource = filteredUsers;
        }

        private List<UsersDesktop> FilterUsersByType(string selectedType)
        {
            var _desktopUsers = UsersDesktopOrm.SelectGlobal();

            if (string.IsNullOrEmpty(selectedType) || selectedType == "all")
            {
                return _desktopUsers;
            } else
            {
                return _desktopUsers.Where(user => user.type == selectedType).ToList();
            }
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

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(askDelete, askDeleteShort, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    UsersDesktopOrm.Delete((UsersDesktop)dataGridViewUsers.SelectedRows[0].DataBoundItem);

                    bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
                    customComboBoxFilter.Texts = Strings.comboBoxFilter;
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                MessageBox.Show(selectionDelete, selectionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm(0, userEdit);
            createUserForm.FormClosed += (s, args) =>
            {
                bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
                customComboBoxFilter.Texts = Strings.comboBoxFilter;
                customComboBoxOrder.Texts = Strings.comboBoxOrder;
            };

            createUserForm.ShowDialog();
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                userEdit = (UsersDesktop)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                CreateUserForm createUserForm = new CreateUserForm(1, userEdit);
                createUserForm.FormClosed += (s, args) =>
                {
                    bindingSourceUsers.DataSource = UsersDesktopOrm.SelectGlobal();
                    customComboBoxFilter.Texts = Strings.comboBoxFilter;
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                };
                createUserForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(selectionEdit, selectionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
