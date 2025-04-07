using System;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace GigFinder
{
    public partial class ChartsForm : Form
    {
        public ChartsForm()
        {
            InitializeComponent();
        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chartType.Series[0].ChartType = SeriesChartType.Pie;

            chartType.Series[0].Points.Clear();
            chartType.Series[0].Points.AddXY("Musicians", UsersOrm.SelectMusicians().Count());
            chartType.Series[0].Points.AddXY("Locals", UsersOrm.SelectLocals().Count());

            chartType.Series[0].Points[0].Color = Color.FromArgb(216, 151, 255);
            chartType.Series[0].Points[1].Color = Color.FromArgb(33, 208, 213);

            chartType.Series[0].Font = new Font("Inter", 12);

            var titulo = new Title("User types");
            titulo.Font = new Font("Passion One", 20, FontStyle.Bold);
            chartType.Titles.Add(titulo);
        }

        private void ChangeLanguage()
        {
            CultureInfo cultura = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = cultura;
            Thread.CurrentThread.CurrentCulture = cultura;
            UpdateTexts();
        }

        private void UpdateTexts()
        {

        }
    }
}
