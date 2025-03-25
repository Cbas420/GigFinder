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
    public partial class ResolveIncidencesForm : Form
    {
        Incidences incidence;
        UsersDesktop userLogin;
        public ResolveIncidencesForm(UsersDesktop user, Incidences incidence)
        {
            InitializeComponent();
            userLogin = user;
            this.incidence = incidence;
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

        }

        private void ResolveIncidencesForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
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
                MessageBox.Show("Completa todos los campos para resolver la incidencia.");
            } else
            {
                roundedTextBoxNote.Texts = "";
                customComboBoxStatus.SelectedItem = null;
                customComboBoxStatus.Texts = "Estado de resolución:";
                IncidenciesOrm.UpdateIncidence(incidence.id, status, note, userLogin.id);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
