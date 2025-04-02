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
    public partial class ManageMusiciansForm : Form
    {
        UsersDesktop userLogin;
        public ManageMusiciansForm(UsersDesktop user)
        {
            InitializeComponent();
            bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
            userLogin = user;
        }

        private void ManageMusiciansForm_Load(object sender, EventArgs e)
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
                CreateMusicianForm createMusician = new CreateMusicianForm();
                if (createMusician.ShowDialog() == DialogResult.OK)
                {
                    bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();
                    Log.createLog("Create Musician", userLogin.id);
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
                if (dataGridViewData.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Estas seguro de que quieres eliminar ese músico.", "Confirmación de eliminación.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        UserMusician userDelete = (UserMusician)dataGridViewData.SelectedRows[0].DataBoundItem;

                        UsersOrm.DeleteUserMusician(userDelete);
                        Log.createLog("Delete Musician", userLogin.id);
                        bindingSourceMusician.DataSource = UsersOrm.SelectMusicians();

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
    }
}
