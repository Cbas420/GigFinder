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
        }

        private void roundedButtonLogin_Click(object sender, EventArgs e)
        {
            SelectAccessForm form = new SelectAccessForm();
            form.ShowDialog();
            this.Hide();
        }
    }
}
