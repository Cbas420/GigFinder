using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static List<IncidenciesFull> SelectGlobal()
        {
            try
            {
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
                return new List<IncidenciesFull>();
            }
        }

        public static List<Incidences> SelectIncidenceByAdmin(int adminId)
        {
            try
            {
                List<Incidences> _incidences = (
                    from incidence in Orm.bd.Incidences
                    where incidence.admin_id == adminId
                    select incidence).ToList();

                return _incidences;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in IncidenciesOrm SelectIncidenceByAdmin: {ex.Message}");
                return new List<Incidences>();
            }
        }

        public static void UpdateIncidence(int incidenceId, string status, string adminNote, int adminId)
        {
            try
            {
                var incidenceToUpdate = Orm.bd.Incidences.FirstOrDefault(i => i.id == incidenceId);

                if (incidenceToUpdate != null)
                {
                    incidenceToUpdate.status = status;
                    incidenceToUpdate.admin_note = adminNote;
                    incidenceToUpdate.admin_id = adminId;

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
