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
    public partial class CreateMusicianForm : Form
    {
        public CreateMusicianForm()
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
            labelTitle.Text = Resources.Strings.labelCreateMusic;
            roundedButtonCreate.Text = Resources.Strings.buttonCreate;
            roundedButtonCancel.Text = Resources.Strings.buttonCancelar;
            customComboBoxLang.Texts = Resources.Strings.comboBoxLang;
            labelConfirmPass.Text = Resources.Strings.labelConfirPass;
            labelDescription.Text = Resources.Strings.labelDescription;
            labelGenres.Text = Resources.Strings.labelGendres;
            labelGroupSize.Text = Resources.Strings.labelGroupSize;
            labelMail.Text = Resources.Strings.labelMail;
            labelName.Text = Resources.Strings.labelName;
            labelPass.Text = Resources.Strings.labelPass;
            labelPrize.Text = Resources.Strings.labelPrice;
        }

        private void CreateMusicianForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }
    }
}
