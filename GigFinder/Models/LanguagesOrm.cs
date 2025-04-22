using System;
using System.Collections.Generic;
using System.Linq;

namespace GigFinder.Models
{
    public class LanguagesOrm
    {
        /// <summary>
        /// Retrieves all languages from the database.
        /// </summary>
        /// <returns>A list of Languages objects representing all available languages in the database.</returns>
        public static List<Languages> SelectGlobal()
        {
            try
            {
                // Retrieve all languages from the database
                List<Languages> _lang = (
                    from lang in Orm.bd.Languages
                    select lang).ToList();

                return _lang;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LanguagesOrm SelectGlobal: {ex.Message}");
                return new List<Languages>(); // Return an empty list in case of an error
            }
        }
    }
}
