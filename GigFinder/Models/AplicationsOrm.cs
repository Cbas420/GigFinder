using System;
using System.Collections.Generic;
using System.Linq;


namespace GigFinder.Models
{
    public class AplicationsOrm
    {
        /// <summary>
        /// Retrieves all application records from the database.
        /// </summary>
        /// <returns>A list of all application records.</returns>
        public static List<Aplications> SelectGlobal()
        {
            try
            {
                // Retrieve all application records from the database
                List<Aplications> _aplication = (
                    from aplication in Orm.bd.Aplications
                    select aplication).ToList();

                return _aplication;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AplicationsOrm SelectGlobal: {ex.Message}");
                return new List<Aplications>(); // Return an empty list in case of an error
            }
        }
    }
}
