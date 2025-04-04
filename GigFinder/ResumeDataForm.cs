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
    public partial class ResumeDataForm : Form
    {
        public ResumeDataForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void ChangeLanguage()
        {
            CultureInfo cultura = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;
            UpdateTexts();
        }

        private void UpdateTexts()
        {
        }

        private void ResumeDataForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }
    }
}
