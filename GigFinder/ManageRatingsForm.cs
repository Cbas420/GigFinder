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
using GigFinder.Entities;
using GigFinder.Models;
using GigFinder.Resources;

namespace GigFinder
{
    public partial class ManageRatingsForm : Form
    {
        UsersDesktop userLogin;
        public ManageRatingsForm(UsersDesktop user)
        {
            InitializeComponent();
            userLogin = user;
            bindingSourceRatings.DataSource = RatingsOrm.SelectGlobal();
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
            
        }

        private void ManageRatingsForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRatings.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estas seguro de que quieres eliminar esa valoración?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    RatingsOrm.Delete((Ratings)dataGridViewRatings.SelectedRows[0].DataBoundItem);
                    Log.createLog("Delete Rating", userLogin.id);
                    bindingSourceRatings.DataSource = RatingsOrm.SelectGlobal();
                    customComboBoxOrder.Texts = Strings.comboBoxOrder;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una valoración para eliminarla.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void customComboBoxOrder_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOrder = customComboBoxOrder.SelectedItem?.ToString();

            var orderedUsers = OrderRatingsBy(selectedOrder);

            bindingSourceRatings.DataSource = orderedUsers;
        }

        private List<Ratings> OrderRatingsBy(string selectedOrder)
        {
            var _ratings = RatingsOrm.SelectGlobal();

            switch (selectedOrder)
            {
                case "User_id":
                    return _ratings.OrderBy(rating => rating.user_id).ToList();

                case "Event_id":
                    return _ratings.OrderBy(rating => rating.event_id).ToList();

                case "Rating":
                    return _ratings.OrderBy(rating => rating.avg_rating).ToList();

                default:
                    return _ratings;
            }
        }
    }
}
