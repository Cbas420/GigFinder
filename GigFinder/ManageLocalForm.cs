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
        String selectionShort;
        String selectionLocalEdit;
        String selectionLocalDelete;
        String accesFunction;
        String accesFunctionShort;
        String askDelete;
        String askDeleteShort;
        public ManageLocalForm(UsersDesktop user)
        {
            InitializeComponent();
            bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
            _userLogin = user;
        }

        private void ManageLocalForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            if (_userLogin.type != "user")
            {
                CreateLocalForm createLocal = new CreateLocalForm(0, _userEdit);
                if (createLocal.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
                    Log.createLog("Create Local", _userLogin.id);
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
                if (dataGridViewLocal.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show(askDelete, askDeleteShort, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        UserLocal userDelete = (UserLocal)dataGridViewLocal.SelectedRows[0].DataBoundItem;

                        UsersOrm.DeleteUserLocal(userDelete);
                        Log.createLog("Delete Local", _userLogin.id);
                        bindingSourceLocal.DataSource = UsersOrm.SelectLocals();

                        customComboBoxOrder.Texts = Strings.comboBoxOrder;
                    }
                }
                else
                {
                    MessageBox.Show(selectionLocalDelete, selectionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            var orderedLocals = OrderLocalsBy(selectedOrder);

            bindingSourceLocal.DataSource = orderedLocals;
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocal.SelectedRows.Count > 0)
            {
                _userEdit = (UserLocal)dataGridViewLocal.SelectedRows[0].DataBoundItem;
                CreateLocalForm createLocalForm = new CreateLocalForm(1, _userEdit);
                if (createLocalForm.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
                    Log.createLog("Edit Local", _userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                MessageBox.Show(selectionLocalEdit, selectionShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
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

        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }    

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
