using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <summary>
        /// Retrieves all ratings from the database, including user names and event details.
        /// </summary>
        /// <returns>A list of RatingsFull objects containing user, event, comment, and rating value information.</returns>
        public static List<RatingsFull> SelectGlobal()
        {
            try
            {
                // Retrieve all ratings, including user name and event details
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error in RatingsOrm SelectGlobal: {ex.Message}");
                return new List<RatingsFull>(); // Return an empty list in case of an error
            }
        }

        /// <summary>
        /// Deletes a rating from the database based on the user ID and event ID.
        /// </summary>
        /// <param name="_rating">The rating object to delete, containing the user ID and event ID.</param>
        public static void Delete(RatingsFull _rating)
        {
            try
            {
                // Find the rating to delete based on the user ID and event ID
                var ratingToDelete = Orm.bd.Ratings.FirstOrDefault(r => r.user_id == _rating.user_id && r.event_id == _rating.event_id);
                if (ratingToDelete != null)
                {
                    // Remove the rating and save changes
                    Orm.bd.Ratings.Remove(ratingToDelete);
                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in RatingsOrm: Rating not found for user ID {_rating.user_id} and event ID {_rating.event_id}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in RatingsOrm Delete: {ex.Message}");
            }
        }
    }
}
