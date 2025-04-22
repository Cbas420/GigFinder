using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <summary>
        /// Retrieves all event records from the database.
        /// </summary>
        /// <returns>A list of all events.</returns>
        public static List<Events> SelectGlobal()
        {
            try
            {
                // Retrieve all event records from the database
                List<Events> _event = (
                    from ev in Orm.bd.Events
                    select ev).ToList();

                return _event;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in EventsOrm SelectGlobal: {ex.Message}");
                return new List<Events>(); // Return an empty list in case of an error
            }
        }

        /// <summary>
        /// Retrieves events and formats them into an event calendar structure.
        /// </summary>
        /// <returns>A list of events with detailed information, formatted as an EventsCalendar object.</returns>
        public static List<EventsCalendar> SelectEventsCalendar()
        {
            try
            {
                // Join Events with Users (for musician and venue) and Genres, then format the results into EventsCalendar
                List<EventsCalendar> _eventsCalendar = (
                    from e in Orm.bd.Events
                    join m in Orm.bd.Users on e.musician_id equals m.id
                    join l in Orm.bd.Users on e.local_id equals l.id
                    join g in Orm.bd.Genres on e.genre_id equals g.id
                    where m.type == "music" && l.type == "local" // Only include music events and local venues
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error in EventsOrm SelectEventsCalendar: {ex.Message}");
                return new List<EventsCalendar>(); // Return an empty list in case of an error
            }
        }
    }
}
