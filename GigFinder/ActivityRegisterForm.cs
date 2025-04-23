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
            activitylogBindingSource.DataSource = Activity_logOrm.SelectGlobal();
        }

        /// <summary>
        /// Handles the form's Load event. It is triggered when the form is loaded.
        /// </summary>
        private void ActivityRegisterForm_Load(object sender, EventArgs e)
        {
            // Changes the language of the form when it is loaded.
            ChangeLanguage();
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
            labelTitle.Text = Strings.titleActivity;
        }
    }
}
