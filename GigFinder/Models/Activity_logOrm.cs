using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class Activity_logOrm
    {
        public static List<Activity_log> SelectGlobal()
        {
            List<Activity_log> _activity = (
                from activity in Orm.bd.Activity_log
                select activity).ToList();

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
