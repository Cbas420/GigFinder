using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class GenresOrm
    {
        public static List<Genres> SelectGlobal()
        {
            List<Genres> _genres = (
                from genre in Orm.bd.Genres
                select genre).ToList();

            return _genres;
        }
    }
}
