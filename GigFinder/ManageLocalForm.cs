﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ManageLocalForm : Form
    {
        UsersDesktop userLogin;
        public ManageLocalForm(UsersDesktop user)
        {
            InitializeComponent();
            userLogin = user;
        }

        private void ManageLocalForm_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
        }
        private void CambiarIdioma()
        {
            CultureInfo cultura = new CultureInfo(LanguageManager.Idioma);
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;
            ActualizarTextos();
        }

        private void ActualizarTextos()
        {
            
        }
    }
}
