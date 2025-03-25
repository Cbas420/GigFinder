using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class IncidenciesOrm
    {
        public static List<Incidences> SelectGlobal()
        {
            List<Incidences> _incidences = (
                from incidence in Orm.bd.Incidences
                select incidence).ToList();

            return _incidences;
        }
    }
}
