using System;
using System.Collections.Generic;
using System.Linq;

namespace GigFinder.Models
{
    public class GenresOrm
    {
        /// <summary>
        /// Retrieves all genre records from the database.
        /// </summary>
        /// <returns>A list of all genres.</returns>
        public static List<Genres> SelectGlobal()
        {
            try
            {
                // Retrieve all genre records from the database
                List<Genres> _genres = (
                    from genre in Orm.bd.Genres
                    select genre).ToList();

                return _genres;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GenresOrm SelectGlobal: {ex.Message}");
                return new List<Genres>(); // Return an empty list in case of an error
            }
        }
    }
}
