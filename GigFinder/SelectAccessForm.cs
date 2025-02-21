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
    public partial class SelectAccessForm : Form
    {
        public SelectAccessForm()
        {
            InitializeComponent();

            manageDatabaseButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#21D0D5");

            manageUsersButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#21D0D5");


        }

        private void buttonManageDatabase_Click(object sender, EventArgs e)
        {



        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm();

            this.Hide();

           // manageUsersForm.Closed += (s, args) => this.Close();

            manageUsersForm.ShowDialog();

            this.Show();
        }
    }
}
