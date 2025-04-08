using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class EventsCalendar
    {
        public int id { get; set; }
        public string musicianName { get; set; }
        public string localName { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public bool opened_offer { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public bool canceled { get; set; }
        public string cancel_msg { get; set; }
        public string genre { get; set; }
    }
    public class EventsOrm
    {
        public static List<Events> SelectGlobal()
        {
            List<Events> _event = (
                from ev in Orm.bd.Events
                select ev).ToList();

            return _event;
        }

        public static List<EventsCalendar> SelectEventsCalendar()
        {
            List<EventsCalendar> _eventsCalendar = (from e in Orm.bd.Events
                                                    join m in Orm.bd.Users on e.musician_id equals m.id
                                                    join l in Orm.bd.Users on e.local_id equals l.id
                                                    join g in Orm.bd.Genres on e.genre_id equals g.id
                                                    where m.type == "music" && l.type == "local"
                                                    select new EventsCalendar
                                                    {
                                                        id = e.id,
                                                        musicianName = m.name,
                                                        localName = l.name,
                                                        dateStart = e.date_start,
                                                        dateEnd = e.date_end,
                                                        opened_offer = (bool)e.opened_offer,
                                                        price = e.price,
                                                        description = e.description,
                                                        canceled = (bool)e.canceled,
                                                        cancel_msg = e.cancel_msg,
                                                        genre = g.name
                                                    }).ToList();

            return _eventsCalendar;
        }
    }
}
