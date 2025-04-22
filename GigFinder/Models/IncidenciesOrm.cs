using System;
using System.Collections.Generic;
using System.Linq;

namespace GigFinder.Models
{
    public class IncidenciesFull
    {
        public int id { get; set; }
        public string description { get; set; }
        public string admin_note { get; set; }
        public string status { get; set; }
        public string user { get; set; }
        public string admin { get; set; }
    }
    public class IncidenciesOrm
    {
        /// <summary>
        /// Retrieves all incidences along with the associated user and admin information.
        /// </summary>
        /// <returns>A list of IncidenciesFull objects containing incidence details along with user and admin information.</returns>
        public static List<IncidenciesFull> SelectGlobal()
        {
            try
            {
                // Retrieve all incidences with associated user and admin data
                List<IncidenciesFull> _incidences = (
                    from incidence in Orm.bd.Incidences
                    join user in Orm.bd.Users on incidence.user_id equals user.id
                    join admin in Orm.bd.UsersDesktop on incidence.admin_id equals admin.id
                    select new IncidenciesFull
                    {
                        id = incidence.id,
                        description = incidence.description,
                        admin_note = incidence.admin_note,
                        status = incidence.status,
                        user = user.name,
                        admin = admin.name
                    }).ToList();

                return _incidences;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in IncidenciesOrm SelectGlobal: {ex.Message}");
                return new List<IncidenciesFull>(); // Return an empty list if an error occurs
            }
        }

        /// <summary>
        /// Retrieves all incidences that are assigned to a specific admin.
        /// </summary>
        /// <param name="adminId">The ID of the admin to filter incidences by.</param>
        /// <returns>A list of Incidences objects assigned to the specified admin.</returns>
        public static List<Incidences> SelectIncidenceByAdmin(int adminId)
        {
            try
            {
                // Retrieve incidences filtered by the assigned admin ID
                List<Incidences> _incidences = (
                    from incidence in Orm.bd.Incidences
                    where incidence.admin_id == adminId
                    select incidence).ToList();

                return _incidences;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in IncidenciesOrm SelectIncidenceByAdmin: {ex.Message}");
                return new List<Incidences>(); // Return an empty list if an error occurs
            }
        }

        /// <summary>
        /// Updates the status, admin notes, and the admin responsible for handling an incidence.
        /// </summary>
        /// <param name="incidenceId">The ID of the incidence to update.</param>
        /// <param name="status">The new status to assign to the incidence.</param>
        /// <param name="adminNote">The admin notes to add for the incidence.</param>
        /// <param name="adminId">The ID of the admin handling the incidence.</param>
        public static void UpdateIncidence(int incidenceId, string status, string adminNote, int adminId)
        {
            try
            {
                // Find the incidence to update based on its ID
                var incidenceToUpdate = Orm.bd.Incidences.FirstOrDefault(i => i.id == incidenceId);

                if (incidenceToUpdate != null)
                {
                    // Update the incidence details
                    incidenceToUpdate.status = status;
                    incidenceToUpdate.admin_note = adminNote;
                    incidenceToUpdate.admin_id = adminId;

                    // Save the changes to the database
                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in IncidenciesOrm incidence with ID {incidenceId} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in IncidenciesOrm UpdateIncidence: {ex.Message}");
            }
        }
    }
}
