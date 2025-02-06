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

        private void loginButton_Paint(object sender, PaintEventArgs e)
        {
            // El color del borde, en este caso #21D0D5
            Color borderColor = System.Drawing.ColorTranslator.FromHtml("#21D0D5");

            // Definir el grosor del borde
            int borderThickness = 2;

            // Dibujar el borde alrededor del botón
            using (Pen borderPen = new Pen(borderColor, borderThickness))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, loginButton.Width - 1, loginButton.Height - 1);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SelectAccessForm accessForm = new SelectAccessForm();


            accessForm.ShowDialog();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
