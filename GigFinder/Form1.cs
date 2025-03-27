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
using GigFinder.Entities;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class Form1 : Form
    {
        string login;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            string mail = roundedTextBoxMail.Texts.Trim();
            string pass = Encrypt.EncryptSHA256(roundedTextBoxPass.Texts.Trim());
            UsersDesktop userLogin = UsersDesktopOrm.Selectlogin(mail, pass);
            if (userLogin != null)
            {
                this.Hide();
                roundedTextBoxPass.Texts = "";
                roundedTextBoxMail.Texts = "";
                SelectAccessForm formMenu = new SelectAccessForm(userLogin);
                formMenu.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                formMenu.Show();
            } else
            {
                roundedTextBoxPass.Texts = "";
                MessageBox.Show(login);
            }
            
        }

        private void pictureBoxES_Click(object sender, EventArgs e)
        {
            LanguageManager.Idioma = "es-ES";
            CambiarIdioma();
        }

        private void pictureBoxEN_Click(object sender, EventArgs e)
        {
            LanguageManager.Idioma = "en-En";
            CambiarIdioma();
        }

        private void pictureBoxCA_Click(object sender, EventArgs e)
        {
            LanguageManager.Idioma = "ca-CA";
            CambiarIdioma();
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
            labelMail.Text = Strings.labelMail;
            labelPass.Text = Strings.labelPass;
            roundedButtonLogin.Text = Strings.buttonLogin;
            login = Strings.messageLogin;
        }
    }
}
