using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ResolveIncidencesForm : Form
    {
        string completeIncidencie;
        string completeIncidencieShort;
        
        IncidenciesFull incidence;
        UsersDesktop userLogin;
        public ResolveIncidencesForm(UsersDesktop user, IncidenciesFull incidence)
        {
            InitializeComponent();
            userLogin = user;
            this.incidence = incidence;
        }
        private void ResolveIncidencesForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }
              
        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            string note = roundedTextBoxNote.Texts.Trim();
            string status = customComboBoxStatus.SelectedItem.ToString();

            if (string.IsNullOrEmpty(note) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show(completeIncidencie, completeIncidencieShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                roundedTextBoxNote.Texts = "";
                customComboBoxStatus.SelectedItem = null;
                customComboBoxStatus.Texts = "Estado de resolución:";
                IncidenciesOrm.UpdateIncidence(incidence.id, status, note, userLogin.id);
                this.DialogResult = DialogResult.OK;
            }
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
            labelTitle.Text = Strings.titleIncidencie;
            labelNote.Text = Strings.resolutionNote;
            customComboBoxStatus.Texts = Strings.resolutionState;
            completeIncidencie = Strings.completeIncidencie;
            completeIncidencieShort = Strings.messageCompleteShort;
        }
    }
}
