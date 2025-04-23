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

        /// <summary>
        /// Handles the form's Load event. Changes the language and initializes the form's components.
        /// </summary>
        private void ResolveIncidencesForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the Cancel button click event. Closes the form.
        /// </summary>
        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Save button click event. Validates the inputs and updates the incidence resolution in the database.
        /// </summary>
        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            string note = roundedTextBoxNote.Texts.Trim();
            string status = customComboBoxStatus.SelectedItem.ToString();

            // Check if note or status is empty and show a warning if necessary
            if (string.IsNullOrEmpty(note) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show(completeIncidencie, completeIncidencieShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Clear the inputs after saving the data
                roundedTextBoxNote.Texts = "";
                customComboBoxStatus.SelectedItem = null;
                customComboBoxStatus.Texts = "Estado de resolución:";

                // Update the incidence in the database
                IncidenciesOrm.UpdateIncidence(incidence.id, status, note, userLogin.id);

                // Set the dialog result to OK to indicate the action was successful
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Changes the language based on the current language setting.
        /// </summary>
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        /// <summary>
        /// Updates the text values on the form according to the current language setting.
        /// </summary>
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
