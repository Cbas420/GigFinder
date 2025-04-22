using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static List<Activity_logFull> SelectGlobal()
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

        public static List<Activity_log> SelectByUser(int id)
        {
            List<Activity_log> _activity = (
                from activity in Orm.bd.Activity_log
                where activity.admin_id == id
                select activity).ToList();

            return _activity;
        }

        public static void Insert(Activity_log _activity)
        {
            Orm.bd.Activity_log.Add(_activity);
            Orm.bd.SaveChanges();
        }
        public static void Delete(Activity_log _activity)
        {
            Orm.bd.Activity_log.Remove(_activity);
            Orm.bd.SaveChanges();
        }
    }
}
