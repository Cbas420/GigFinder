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
    public partial class ManageDatabaseForm : Form
    {
        public ManageDatabaseForm()
        {
            InitializeComponent();
        }

        private void ManageDatabaseForm_Load(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Add(new object[] { 1, "Joel", "Camps", "joel@example.com", "1234" });
            dataGridViewData.Rows.Add(new object[] { 2, "Jordi", "Bonet", "jordi@example.com", "1234" });
            dataGridViewData.Rows.Add(new object[] { 3, "Helio", "Verdugo", "helio@example.com", "1234" });
            dataGridViewData.Rows.Add(new object[] { 4, "Alex", "Cubells", "alex@example.com", "1234" });
        }
    }
}
