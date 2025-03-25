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

namespace GigFinder
{
    public partial class ManageIncidencesForm : Form
    {
        public ManageIncidencesForm()
        {
            InitializeComponent();
            bindingSourceIncidencies.DataSource = IncidenciesOrm.SelectGlobal();
        }

        private void ManageIncidencesForm_Load(object sender, EventArgs e)
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

        private void roundedButtonResolve_Click(object sender, EventArgs e)
        {

        }

        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedIncidences = OrderIncidencesBy(selectedOrder);

            bindingSourceIncidencies.DataSource = orderedIncidences;
        }

        private List<Incidences> OrderIncidencesBy(string selectedOrder)
        {
            var _incidences = IncidenciesOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "Status":
                    return _incidences.OrderBy(incidence => incidence.status).ToList();

                case "User_id":
                    return _incidences.OrderBy(incidence => incidence.user_id).ToList();

                case "Admin_id":
                    return _incidences.OrderBy(incidence => incidence.admin_id).ToList();

                default:
                    return _incidences;
            }
        }

        private void customComboBoxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString().ToLower();

            var filteredIncidences = FilterIncidencesByStatus(selectedValue);

            bindingSourceIncidencies.DataSource = filteredIncidences;
        }

        private List<Incidences> FilterIncidencesByStatus(string selectedType)
        {
            var _incidences = IncidenciesOrm.SelectGlobal();

            if (string.IsNullOrEmpty(selectedType) || selectedType == "all")
            {
                return _incidences;
            }
            else
            {
                return _incidences.Where(incidence => incidence.status == selectedType).ToList();
            }
        }
    }
}
