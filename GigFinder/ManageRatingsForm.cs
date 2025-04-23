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
    public partial class ManageRatingsForm : Form
    {
        string selecctionRequired;
        string selecctionRequiredShort;
        string confirmDelete;
        string confirmDeleteShort;
        UsersDesktop _userLogin;
        public ManageRatingsForm(UsersDesktop user)
        {
            InitializeComponent();
            _userLogin = user;
            bindingSourceRatings.DataSource = RatingsOrm.SelectGlobal();
        }

        /// <summary>
        /// Handles the form load event. Applies current language settings to UI text.
        /// </summary>
        private void ManageRatingsForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        /// <summary>
        /// Handles the click event for the delete button. Deletes the selected rating after user confirmation.
        /// </summary>
        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRatings.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(confirmDelete, confirmDeleteShort, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Perform deletion and refresh data
                    RatingsOrm.Delete((RatingsFull)dataGridViewRatings.SelectedRows[0].DataBoundItem);
                    Log.createLog("Delete Rating", _userLogin.id);
                    bindingSourceRatings.DataSource = RatingsOrm.SelectGlobal();
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                // Prompt user to select a rating before deleting
                MessageBox.Show(selecctionRequired, selecctionRequiredShort, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the order combo box selection change event. Sorts ratings based on the selected field.
        /// </summary>
        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();
            var orderedUsers = OrderRatingsBy(selectedOrder);
            bindingSourceRatings.DataSource = orderedUsers;
        }

        /// <summary>
        /// Sorts the list of ratings by the specified order option.
        /// </summary>
        /// <param name="selectedOrder">The selected sorting criteria.</param>
        /// <returns>A sorted list of <see cref="RatingsFull"/> objects.</returns>
        private List<RatingsFull> OrderRatingsBy(string selectedOrder)
        {
            var _ratings = RatingsOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "User":
                    return _ratings.OrderBy(rating => rating.user_id).ToList();
                case "Event_id":
                    return _ratings.OrderBy(rating => rating.event_id).ToList();
                case "Rating":
                    return _ratings.OrderBy(rating => rating.ratingValue).ToList();
                default:
                    return _ratings;
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
            confirmDelete = Strings.askDeleteRating;
            confirmDeleteShort = Strings.askDeleteShort;
            selecctionRequiredShort = Strings.selectionShort;
            selecctionRequired = Strings.selectRating;
            customComboBoxOrder.Texts = Strings.comboBoxOrder;
            roundedButtonDelete.Text = Strings.buttonDelete;
            labelTitle.Text = Strings.titleRatings;
        }
    }
}
