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
    public partial class SelectAccessForm : Form
    {
        UsersDesktop userLogin;
        public SelectAccessForm(UsersDesktop user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userLogin = user;
        }
    }
}
