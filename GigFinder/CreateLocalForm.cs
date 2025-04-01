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
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            labelTitle.Text = Strings.labelCreateLocal;
            roundedButtonCreate.Text = Strings.buttonCreate;
            roundedButtonCancel.Text = Strings.buttonCancelar;
            labelConfirmPass.Text = Strings.labelConfirPass;
            labelDescription.Text = Strings.labelDescription;
            labelGenres.Text = Strings.labelGendres;
            labelMail.Text = Strings.labelMail;
            labelName.Text = Strings.labelName;
            labelPass.Text = Strings.labelPass;
            labelCapacity.Text = Strings.labelLocalCapacity;
            labelCoordX.Text = Strings.labelCoordX;
            labelCoordY.Text = Strings.labelCoordY;
        }

        private void CreateLocalForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }
    }
}
