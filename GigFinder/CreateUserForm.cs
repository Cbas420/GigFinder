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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
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
            labelTitle.Text = Resources.Strings.labelCreateUser;
            labelMail.Text = Resources.Strings.labelMail;
            labelName.Text = Resources.Strings.labelName;
            labelConfirmPass.Text = Resources.Strings.labelConfirPass;
            labelPass.Text = Resources.Strings.labelPass;
            labelSurname.Text = Resources.Strings.labelSurname;
            customComboBoxType.Texts = Resources.Strings.comboBoxUserType;
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
        }
    }
}
