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
            CambiarIdioma();
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
            
        }
    }
}
