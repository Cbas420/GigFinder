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

        private void ActivityRegisterForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
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
            labelTitle.Text = Strings.titleActivity;
        }
    }
}
