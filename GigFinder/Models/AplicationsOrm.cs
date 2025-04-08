using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class AplicationsOrm
    {
        public static List<Aplications> SelectGlobal()
        {
            List<Aplications> _aplication = (
                from aplication in Orm.bd.Aplications
                select aplication).ToList();

            return _aplication;
        }
    }
}
