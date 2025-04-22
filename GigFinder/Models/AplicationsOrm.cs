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
            try
            {
                List<Aplications> _aplication = (
                    from aplication in Orm.bd.Aplications
                    select aplication).ToList();

                return _aplication;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AplicationsOrm SelectGlobal: {ex.Message}");
                return new List<Aplications>();
            }
        }
    }
}
