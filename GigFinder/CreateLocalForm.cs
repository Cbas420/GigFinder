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
    public partial class CreateLocalForm : Form
    {
        public CreateLocalForm()
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
            labelTitle.Text = Resources.Strings.labelCreateLocal;
            roundedButtonCreate.Text = Resources.Strings.buttonCreate;
            roundedButtonCancel.Text = Resources.Strings.buttonCancelar;
            labelConfirmPass.Text = Resources.Strings.labelConfirPass;
            labelDescription.Text = Resources.Strings.labelDescription;
            labelGenres.Text = Resources.Strings.labelGendres;
            labelMail.Text = Resources.Strings.labelMail;
            labelName.Text = Resources.Strings.labelName;
            labelPass.Text = Resources.Strings.labelPass;
            labelCapacity.Text = Resources.Strings.labelLocalCapacity;
            labelCoordX.Text = Resources.Strings.labelCoordX;
            labelCoordY.Text = Resources.Strings.labelCoordY;
        }

        private void CreateLocalForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
        }
    }
}
