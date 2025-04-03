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
using GigFinder.Entities;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ManageLocalForm : Form
    {
        UserLocal _userEdit = null;
        UsersDesktop userLogin;
        public ManageLocalForm(UsersDesktop user)
        {
            InitializeComponent();
            bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
            userLogin = user;
        }

        private void ManageLocalForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
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
            
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            if (userLogin.type != "user")
            {
                CreateLocalForm createLocal = new CreateLocalForm(0, _userEdit);
                if (createLocal.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
                    Log.createLog("Create Local", userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                MessageBox.Show("No tienes permisos para utilizar esta función de la aplicación.");
            }
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (userLogin.type != "user")
            {
                if (dataGridViewLocal.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro de que quieres eliminar ese local?", "Confirmación de eliminación.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        UserLocal userDelete = (UserLocal)dataGridViewLocal.SelectedRows[0].DataBoundItem;

                        UsersOrm.DeleteUserLocal(userDelete);
                        Log.createLog("Delete Local", userLogin.id);
                        bindingSourceLocal.DataSource = UsersOrm.SelectLocals();

                        customComboBoxOrder.Texts = Strings.comboBoxOrder;
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un músico para eliminarlo.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No tienes permisos para utilizar esta función de la aplicación.");
            }
        }

        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedLocals = OrderLocalsBy(selectedOrder);

            bindingSourceLocal.DataSource = orderedLocals;
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

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocal.SelectedRows.Count > 0)
            {
                _userEdit = (UserLocal)dataGridViewLocal.SelectedRows[0].DataBoundItem;
                CreateLocalForm createLocalForm = new CreateLocalForm(1, _userEdit);
                if (createLocalForm.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceLocal.DataSource = UsersOrm.SelectLocals();
                    Log.createLog("Edit Local", userLogin.id);
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un local para poder editarlo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
