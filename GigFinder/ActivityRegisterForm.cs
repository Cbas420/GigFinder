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
    public partial class ActivityRegisterForm : Form
    {
        public ActivityRegisterForm()
        {
            InitializeComponent();
            activitylogBindingSource.DataSource = Activity_logOrm.SelectGlobal();
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
            labelTitle.Text = Resources.Strings.titleActivity;
        }

        private void ActivityRegisterForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
        }
    }
}
