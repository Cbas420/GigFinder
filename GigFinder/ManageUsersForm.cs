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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();

            searchButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#21D0D5");

            createButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#21D0D5");

            deleteButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#21D0D5");

            saveButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#21D0D5");

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");

            filterUserPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#C3C3C3");

            databaseManagementPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#C3C3C3");

            actionsToolStrip.BackColor = System.Drawing.ColorTranslator.FromHtml("#C3C3C3");


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void filterUserPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.filterUserPanel.ClientRectangle, ColorTranslator.FromHtml("#21D0D5"), ButtonBorderStyle.Solid);
        }

        private void databaseManagementPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.databaseManagementPanel.ClientRectangle, ColorTranslator.FromHtml("#21D0D5"), ButtonBorderStyle.Solid);
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
