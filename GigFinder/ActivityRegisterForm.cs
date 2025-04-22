using System;
using System.Globalization;
using System.Threading;
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
            // Binds the data source to the activity log.
            activitylogBindingSource.DataSource = Activity_logOrm.SelectGlobal();
        }

        /// <summary>
        /// Handles the form's Load event. It is triggered when the form is loaded.
        /// </summary>
        /// <param name="sender">The sender object of the event.</param>
        /// <param name="e">The event data.</param>
        private void ActivityRegisterForm_Load(object sender, EventArgs e)
        {
            // Changes the language of the form when it is loaded.
            ChangeLanguage();
        }

        /// <summary>
        /// Changes the language of the form based on the selected language in the language manager.
        /// </summary>
        private void ChangeLanguage()
        {
            // Sets the culture info based on the selected language in the LanguageManager.
            CultureInfo culture = new CultureInfo(LanguageManager.language);

            // Applies the culture settings to the current thread.
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            // Updates the text of the UI controls after changing the language.
            UpdateTexts();
        }

        /// <summary>
        /// Updates the UI text to reflect the current language.
        /// </summary>
        private void UpdateTexts()
        {
            // Sets the title label text to the localized string for the activity title.
            labelTitle.Text = Strings.titleActivity;
        }
    }
}
