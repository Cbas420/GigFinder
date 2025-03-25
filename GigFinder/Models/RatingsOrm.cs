using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class RatingsOrm
    {
        public static List<Ratings> SelectGlobal()
        {
            List<Ratings> _ratings = (
                from rating in Orm.bd.Ratings
                select rating).ToList();

            return _ratings;
        }

        public static void Delete(Ratings _rating)
        {
            Orm.bd.Ratings.Remove(_rating);
            Orm.bd.SaveChanges();
        }
    }
}
