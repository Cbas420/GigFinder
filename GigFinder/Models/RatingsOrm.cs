using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class RatingsFull
    {
        public int user_id { get; set; }
        public string user { get; set; }
        public int event_id { get; set; }
        public string comment { get; set; }
        public int ratingValue { get; set; }
    }

    public class RatingsOrm
    {
        public static List<RatingsFull> SelectGlobal()
        {
            List<RatingsFull> _ratings = (
                from rating in Orm.bd.Ratings
                join user in Orm.bd.Users on rating.user_id equals user.id
                join events in Orm.bd.Events on rating.event_id equals events.id
                select new RatingsFull
                {
                    user_id = rating.user_id,
                    user = user.name,
                    event_id = rating.event_id,
                    comment = rating.content,
                    ratingValue = rating.avg_rating
                }).ToList();

            return _ratings;
        }

        public static void Delete(RatingsFull _rating)
        {
            var ratingToDelete = Orm.bd.Ratings.FirstOrDefault(r => r.user_id == _rating.user_id && r.event_id == _rating.event_id);
            if (ratingToDelete != null)
            {
                Orm.bd.Ratings.Remove(ratingToDelete);
                Orm.bd.SaveChanges();
            }
        }
    }
}
