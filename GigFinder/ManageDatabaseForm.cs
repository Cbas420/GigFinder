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
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ManageDatabaseForm : Form
    {
        public ManageDatabaseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            labelTitle.Text = Resources.Strings.titleData;
            
        }

        private void ManageDatabaseForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
        }
    }
}
