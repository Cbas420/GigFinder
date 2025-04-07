using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ResumeDataForm : Form
    {
        
        public ResumeDataForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }    

        private void ResumeDataForm_Load(object sender, EventArgs e)
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
