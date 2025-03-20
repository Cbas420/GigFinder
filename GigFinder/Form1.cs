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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int positionX = (screenWidth - formWidth) / 2;
            int positionY = (screenHeight - formHeight) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(positionX, positionY);
        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            UsersDesktop userLogin = UsersDesktopOrm.Selectlogin(roundedTextBoxMail.Texts, roundedTextBoxPass.Texts);
            if (userLogin != null)
            {
                SelectAccessForm formMenu = new SelectAccessForm(userLogin);
                formMenu.Show();


                
            } else
            {
                MessageBox.Show("El usuario y/o la contraseña son incorrectos");
            }
            
        }

        
    }
}
