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
        string loginShort;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            string mail = roundedTextBoxMail.Texts.Trim();
            string pass = Encrypt.EncryptSHA256(roundedTextBoxPass.Texts.Trim());
            UsersDesktop _userLogin = UsersDesktopOrm.Selectlogin(mail, pass);
            if (_userLogin != null)
            {
                this.Hide();
                roundedTextBoxPass.Texts = "";
                roundedTextBoxMail.Texts = "";
                SelectAccessForm formMenu = new SelectAccessForm(_userLogin);
                formMenu.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                formMenu.Show();
            } else
            {
                roundedTextBoxPass.Texts = "";
                MessageBox.Show(login, loginShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void pictureBoxES_Click(object sender, EventArgs e)
        {
            LanguageManager.language = "es-ES";
            ChangeLanguage();
        }

        private void pictureBoxEN_Click(object sender, EventArgs e)
        {
            LanguageManager.language = "en-En";
            ChangeLanguage();
        }

        private void pictureBoxCA_Click(object sender, EventArgs e)
        {
            LanguageManager.language = "ca-CA";
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
            labelMail.Text = Strings.labelMail;
            labelPass.Text = Strings.labelPass;
            roundedButtonLogin.Text = Strings.buttonLogin;
            login = Strings.messageLogin;
            loginShort = Strings.loginShort;
        }

        
    }
}
