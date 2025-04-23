using System;
using System.Globalization;
using System.Threading;
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

        /// <summary>
        /// Event handler for when the form loads.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Event handler for the Login button click event. This method validates the user login.
        /// </summary>
        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            // Retrieve and trim the input email and password.
            string mail = roundedTextBoxMail.Texts.Trim();
            string pass = Encrypt.EncryptSHA256(roundedTextBoxPass.Texts.Trim());

            // Check the login credentials against the database.
            UsersDesktop _userLogin = UsersDesktopOrm.Selectlogin(mail, pass);

            if (_userLogin != null)
            {
                // If the user is found, hide the current form and open the SelectAccessForm.
                this.Hide();
                roundedTextBoxPass.Texts = "";
                roundedTextBoxMail.Texts = "";
                SelectAccessForm formMenu = new SelectAccessForm(_userLogin);

                // Handle the event when the SelectAccessForm is closed.
                formMenu.FormClosed += (s, args) =>
                {
                    this.Show(); // Show the original form again after the new form is closed.
                };

                formMenu.Show(); // Show the SelectAccessForm.
            }
            else
            {
                // If the login fails, clear the password field and show a warning message.
                roundedTextBoxPass.Texts = "";
                MessageBox.Show(login, loginShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Event handler for the click event of the Spanish language selection button.
        /// </summary>
        private void pictureBoxES_Click(object sender, EventArgs e)
        {
            LanguageManager.language = "es-ES"; // Set the language to Spanish.
            ChangeLanguage(); // Update the UI text based on the selected language.
        }

        /// <summary>
        /// Event handler for the click event of the English language selection button.
        /// </summary>
        private void pictureBoxEN_Click(object sender, EventArgs e)
        {
            LanguageManager.language = "en-En"; // Set the language to English.
            ChangeLanguage(); // Update the UI text based on the selected language.
        }

        /// <summary>
        /// Event handler for the click event of the Catalan language selection button.
        /// </summary>
        private void pictureBoxCA_Click(object sender, EventArgs e)
        {
            LanguageManager.language = "ca-CA"; // Set the language to Catalan.
            ChangeLanguage(); // Update the UI text based on the selected language.
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
            labelMail.Text = Strings.labelMail;
            labelPass.Text = Strings.labelPass;
            roundedButtonLogin.Text = Strings.buttonLogin;
            login = Strings.messageLogin;
            loginShort = Strings.loginShort;
        }
    }
}
