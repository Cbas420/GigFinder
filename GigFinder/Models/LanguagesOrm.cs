using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class LanguagesOrm
    {
        public static List<Languages> SelectGlobal()
        {
            try
            {
                List<Languages> _lang = (
                    from lang in Orm.bd.Languages
                    select lang).ToList();

                return _lang;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LanguagesOrm SelectGlobal: {ex.Message}");
                return new List<Languages>();
            }
        }
    }
}
