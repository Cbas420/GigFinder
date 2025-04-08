using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class EventsOrm
    {
        public static List<Events> SelectGlobal()
        {
            List<Events> _event = (
                from ev in Orm.bd.Events
                select ev).ToList();

            return _event;
        }
    }
}
