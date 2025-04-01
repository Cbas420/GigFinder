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
    public partial class CreateMusicianForm : Form
    {
        public CreateMusicianForm()
        {
            InitializeComponent();
            bindingSourceGenres.DataSource = GenresOrm.SelectGlobal();
            bindingSourceLang.DataSource = LanguagesOrm.SelectGlobal();
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
            labelTitle.Text = Strings.labelCreateMusic;
            roundedButtonCreate.Text = Strings.buttonCreate;
            roundedButtonCancel.Text = Strings.buttonCancelar;
            customComboBoxLang.Texts = Strings.comboBoxLang;
            labelConfirmPass.Text = Strings.labelConfirPass;
            labelDescription.Text = Strings.labelDescription;
            labelGenres.Text = Strings.labelGendres;
            labelGroupSize.Text = Strings.labelGroupSize;
            labelMail.Text = Strings.labelMail;
            labelName.Text = Strings.labelName;
            labelPass.Text = Strings.labelPass;
            labelPrize.Text = Strings.labelPrice;
        }

        private void CreateMusicianForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
