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
        string selectionIncidencie;
        string selectionIncidencieShort;
        string resolvedIncidencie;
        string resolvedIncidencieShort;
        public ManageIncidencesForm(UsersDesktop user)
        {
            InitializeComponent();
            _userLogin = user;
            bindingSourceIncidencies.DataSource = IncidenciesOrm.SelectGlobal();
        }

        /// <summary>
        /// Handles the form load event and sets UI language and texts.
        /// </summary>
        private void ManageIncidencesForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the click event of the resolve button.
        /// Opens a form to resolve the selected incidence if its status is "pendent".
        /// </summary>
        private void roundedButtonResolve_Click(object sender, EventArgs e)
        {
            if (dataGridViewIncidencies.SelectedRows.Count > 0)
            {
                IncidenciesFull incidence = (IncidenciesFull)dataGridViewIncidencies.SelectedRows[0].DataBoundItem;

                if (incidence.status == "pendent")
                {
                    ResolveIncidencesForm createUserForm = new ResolveIncidencesForm(_userLogin, incidence);
                    if (createUserForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh data and UI text after resolving
                        bindingSourceIncidencies.DataSource = IncidenciesOrm.SelectGlobal();
                        Log.createLog("Resolve Incidencie", _userLogin.id);
                        customComboBoxFilter.Texts = Strings.comboBoxFilter;
                        customComboBoxOrder.Texts = Strings.comboBoxOrder;
                    }
                }
                else
                {
                    // Warn user that the incidence is already resolved
                    MessageBox.Show(resolvedIncidencie, resolvedIncidencieShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Warn user to select an incidence
                MessageBox.Show(selectionIncidencie, selectionIncidencieShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles changes in the order combo box and reorders the incidences accordingly.
        /// </summary>
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();
            var orderedIncidences = OrderIncidencesBy(selectedOrder);
            bindingSourceIncidencies.DataSource = orderedIncidences;
        }

        /// <summary>
        /// Handles changes in the filter combo box and filters the incidences accordingly.
        /// </summary>
        private void customComboBoxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = customComboBoxFilter.SelectedItem?.ToString().ToLower();
            var filteredIncidences = FilterIncidencesByStatus(selectedValue);
            bindingSourceIncidencies.DataSource = filteredIncidences;
        }

        /// <summary>
        /// Filters the list of incidences by the given status type.
        /// </summary>
        /// <param name="selectedType">The status to filter by (e.g., "pendent", "resolved").</param>
        /// <returns>A filtered list of <see cref="IncidenciesFull"/> objects.</returns>
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

        /// <summary>
        /// Orders the list of incidences by the selected property.
        /// </summary>
        /// <param name="selectedOrder">The property to order by (e.g., "Id", "Status").</param>
        /// <returns>An ordered list of <see cref="IncidenciesFull"/> objects.</returns>
        private List<IncidenciesFull> OrderIncidencesBy(string selectedOrder)
        {
            var _incidences = IncidenciesOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "Id":
                    return _incidences.OrderBy(incidence => incidence.id).ToList();
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

        /// <summary>
        /// Changes the language based on the current language setting.
        /// </summary>
        private void ChangeLanguage()
        {
            CultureInfo culture = new CultureInfo(LanguageManager.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            UpdateTexts();
        }

        /// <summary>
        /// Updates the text values on the form according to the current language setting.
        /// </summary>
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
