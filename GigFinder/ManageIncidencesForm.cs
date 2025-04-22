using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GigFinder.Entities;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ManageIncidencesForm : Form
    {
        UsersDesktop _userLogin;
        String selectionIncidencie;
        String selectionIncidencieShort;
        String resolvedIncidencie;
        String resolvedIncidencieShort;
        public ManageIncidencesForm(UsersDesktop user)
        {
            InitializeComponent();
            _userLogin = user;
            bindingSourceIncidencies.DataSource = IncidenciesOrm.SelectGlobal();
        }

        private void ManageIncidencesForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void roundedButtonResolve_Click(object sender, EventArgs e)
        {
            if (dataGridViewIncidencies.SelectedRows.Count > 0)
            {
                Incidences incidence = (Incidences)dataGridViewIncidencies.SelectedRows[0].DataBoundItem;
                if (incidence.status == "pendent")
                {
                    ResolveIncidencesForm createUserForm = new ResolveIncidencesForm(_userLogin, incidence);
                    if (createUserForm.ShowDialog() == DialogResult.OK)
                    {
                        bindingSourceIncidencies.DataSource = IncidenciesOrm.SelectGlobal();
                        Log.createLog("Resolve Incidencie", _userLogin.id);
                        customComboBoxFilter.Texts = Strings.comboBoxFilter;
                        customComboBoxOrder.Texts = Strings.comboBoxOrder;
                    }
                } else
                {
                    MessageBox.Show(resolvedIncidencie, resolvedIncidencieShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show(selectionIncidencie, selectionIncidencieShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedIncidences = OrderIncidencesBy(selectedOrder);

            bindingSourceIncidencies.DataSource = orderedIncidences;
        }

        private void customComboBoxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString().ToLower();

            var filteredIncidences = FilterIncidencesByStatus(selectedValue);

            bindingSourceIncidencies.DataSource = filteredIncidences;
        }
        
        private List<IncidenciesFull> FilterIncidencesByStatus(string selectedType)
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
        private List<IncidenciesFull> OrderIncidencesBy(string selectedOrder)
        {
            
            var _incidences = IncidenciesOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "Status":
                    return _incidences.OrderBy(incidence => incidence.status).ToList();

                case "User_id":
                    return _incidences.OrderBy(incidence => incidence.user).ToList();

                case "Admin_id":
                    return _incidences.OrderBy(incidence => incidence.admin).ToList();

                default:
                    return _incidences;
            }
        }

        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            customComboBoxFilter.Texts = Strings.comboBoxFilter;
            customComboBoxOrder.Texts = Strings.comboBoxOrder;
            selectionIncidencieShort = Strings.selectionShort;
            selectionIncidencie = Strings.selectionIncidencie;
            resolvedIncidencieShort = Strings.resolvedIncidencieShort;
            resolvedIncidencie = Strings.resolvedIncidencie;
        }
    }
}
