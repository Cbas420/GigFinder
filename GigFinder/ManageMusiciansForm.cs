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
                createMusician.ShowDialog();
            } 
            else
            {
                MessageBox.Show("No tienes permisos para utilizar esta función de la aplicación.");
            }
        }
    }
}
