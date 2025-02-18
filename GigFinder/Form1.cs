using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            loginButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#21D0D5");

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            SelectAccessForm accessForm = new SelectAccessForm();

            this.Hide();

            accessForm.Closed += (s, args) => this.Close();

            accessForm.Show();

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
