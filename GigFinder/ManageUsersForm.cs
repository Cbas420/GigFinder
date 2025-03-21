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
            labelTitle.Text = Resources.Strings.titleUsers;
            customComboBoxFilter.Texts = Resources.Strings.comboBoxFilter;
            customComboBoxOrder.Texts = Resources.Strings.comboBoxOrder;
            roundedButtonCreate.Text = Resources.Strings.buttonCreate;
            roundedButtonEdit.Text = Resources.Strings.buttonEdit;
            roundedButtonDelete.Text = Resources.Strings.buttonDelete;
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
        }

        private void customComboBoxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString();

            var filteredUsers = FilterUsersByType(selectedValue);

            bindingSourceUsers.DataSource = filteredUsers;
        }

        private List<UsersDesktop> FilterUsersByType(string selectedType)
        {
            var _desktopUsers = UsersDesktopOrm.SelectGlobal();

            if (string.IsNullOrEmpty(selectedType) || selectedType == "All")
            {
                return _desktopUsers;
            }
            else
            {
                return _desktopUsers.Where(user => user.type == selectedType.ToLower()).ToList();
            }
        }
    }
}
