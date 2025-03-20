using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigFinder.Models;

namespace GigFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            UsersDesktop userLogin = UsersDesktopOrm.Selectlogin(roundedTextBoxMail.Texts.Trim(), roundedTextBoxPass.Texts.Trim());
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
                MessageBox.Show("El usuario y/o la contraseña son incorrectos");
            }
            
        }

        
    }
}
