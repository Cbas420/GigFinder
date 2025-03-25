using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GigFinder.Models;

namespace GigFinder.Entities
{
    public class Log
    {
        public static void createLog(string action, int id)
        {
            Activity_log _activity = new Activity_log();
            _activity.date_log = DateTime.Now;
            _activity.action_made = action;
            _activity.admin_id = id;
            Activity_logOrm.Insert(_activity);
        }
    }
}
