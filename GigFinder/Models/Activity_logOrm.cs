using System;
using System.Collections.Generic;
using System.Linq;

namespace GigFinder.Models
{
    public class Activity_logFull
    {
        public int id { get; set; }
        public string admin { get; set; }
        public string activity { get; set; }
        public DateTime date { get; set; }
    }

    public class Activity_logOrm
    {
        /// <summary>
        /// Retrieves all activity logs with user details.
        /// </summary>
        /// <returns>A list of activity logs with the admin's name, action performed, and the date of the log.</returns>
        public static List<Activity_logFull> SelectGlobal()
        {
            try
            {
                // Join Activity_log with UsersDesktop based on the admin_id
                List<Activity_logFull> _activity = (
                    from activity in Orm.bd.Activity_log
                    join user in Orm.bd.UsersDesktop on activity.admin_id equals user.id
                    select new Activity_logFull
                    {
                        id = activity.id,
                        admin = user.name, // Get the admin's name from the UsersDesktop table
                        activity = activity.action_made,
                        date = activity.date_log
                    }).ToList();

                return _activity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Activity_logOrm SelectGlobal: {ex.Message}");
                return new List<Activity_logFull>(); // Return an empty list in case of an error
            }
        }

        /// <summary>
        /// Inserts a new activity log into the database.
        /// </summary>
        /// <param name="_activity">The activity log entry to insert.</param>
        public static void Insert(Activity_log _activity)
        {
            try
            {
                // Add the new activity log entry to the database
                Orm.bd.Activity_log.Add(_activity);
                Orm.bd.SaveChanges(); // Save the changes to the database
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Activity_logOrm Insert: {ex.Message}");
            }
        }
    }
}
