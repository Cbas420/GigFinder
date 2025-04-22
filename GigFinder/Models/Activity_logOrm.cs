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
        /// <returns>A list of activity logs with the admin's name and action performed.</returns>
        public static List<Activity_logFull> SelectGlobal()
        {
            try
            {
                List<Activity_logFull> _activity = (
                    from activity in Orm.bd.Activity_log
                    join user in Orm.bd.UsersDesktop on activity.admin_id equals user.id
                    select new Activity_logFull
                    {
                        id = activity.id,
                        admin = user.name,
                        activity = activity.action_made,
                        date = activity.date_log
                    }).ToList();

                return _activity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Activity_logOrm SelectGlobal: {ex.Message}");
                return new List<Activity_logFull>();
            }
        }

        /// <summary>
        /// Retrieves activity logs for a specific user.
        /// </summary>
        /// <param name="id">The user ID to filter activity logs by.</param>
        /// <returns>A list of activity logs for the specified user.</returns>
        public static List<Activity_log> SelectByUser(int id)
        {
            try
            {
                List<Activity_log> _activity = (
                    from activity in Orm.bd.Activity_log
                    where activity.admin_id == id
                    select activity).ToList();

                return _activity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Activity_logOrm SelectByUser: {ex.Message}");
                return new List<Activity_log>();
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
                Orm.bd.Activity_log.Add(_activity);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Activity_logOrm Insert: {ex.Message}");
            }
        }
    }
}
