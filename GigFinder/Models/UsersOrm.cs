using System;
using System.Collections.Generic;
using System.Linq;

namespace GigFinder.Models
{
    public class UserMusician
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string type = "music";

        public int size { get; set; }
        public int price { get; set; }
        public string lang { get; set; }
    }

    public class UserLocal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string type = "local";

        public int capacity { get; set; }
        public double x_coordination { get; set; }
        public double y_coordination { get; set; }
    }

    public class UsersOrm
    {
        /// <summary>
        /// Retrieves a list of active musicians from the database.
        /// </summary>
        /// <returns>A list of active musicians with their details.</returns>
        public static List<UserMusician> SelectMusicians()
        {
            try
            {
                // Retrieve a list of musicians who are active
                List<UserMusician> _userMusician = (from u in Orm.bd.Users
                                                    join m in Orm.bd.Musicians on u.id equals m.id
                                                    join l in Orm.bd.Languages on m.songs_lang equals l.id
                                                    where u.type == "music" && u.active == true
                                                    select new UserMusician
                                                    {
                                                        id = u.id,
                                                        name = u.name,
                                                        description = u.description,
                                                        email = u.email,
                                                        password = u.password,
                                                        size = m.size,
                                                        price = m.price,
                                                        lang = l.lang
                                                    }).ToList();

                return _userMusician;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm SelectMusicians: {ex.Message}");
                return new List<UserMusician>(); // Return an empty list in case of error
            }
        }

        /// <summary>
        /// Retrieves a list of active local venues from the database.
        /// </summary>
        /// <returns>A list of active local venues with their details.</returns>
        public static List<UserLocal> SelectLocals()
        {
            try
            {
                // Retrieve a list of local venues who are active
                List<UserLocal> _userLocal = (from u in Orm.bd.Users
                                              join l in Orm.bd.Locals on u.id equals l.id
                                              where u.type == "local" && u.active == true
                                              select new UserLocal
                                              {
                                                  id = u.id,
                                                  name = u.name,
                                                  description = u.description,
                                                  email = u.email,
                                                  password = u.password,
                                                  capacity = l.capacity,
                                                  x_coordination = l.x_coordination,
                                                  y_coordination = l.y_coordination,
                                              }).ToList();

                return _userLocal;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm SelectLocals: {ex.Message}");
                return new List<UserLocal>(); // Return an empty list in case of error
            }
        }

        /// <summary>
        /// Inserts a new user into the Users table.
        /// </summary>
        /// <param name="_user">The user to insert into the database.</param>
        public static void InsertUser(Users _user)
        {
            try
            {
                // Add the new user and save the changes to the database
                Orm.bd.Users.Add(_user);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm InsertUser: {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves a user from the Users table based on their email.
        /// </summary>
        /// <param name="email">The email address of the user to retrieve.</param>
        /// <returns>The user matching the provided email, or null if not found.</returns>
        public static Users SelectUserWithMail(string email)
        {
            try
            {
                // Retrieve the user with the provided email
                Users _user =
                    (Users)(from user in Orm.bd.Users
                            where user.email == email && user.active == true
                            select user).FirstOrDefault();

                return _user;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm SelectUserWithMail: {ex.Message}");
                return null; // Return null if user is not found
            }
        }

        /// <summary>
        /// Retrieves a musician based on their ID.
        /// </summary>
        /// <param name="id">The ID of the musician to retrieve.</param>
        /// <returns>The musician matching the provided ID, or null if not found.</returns>
        public static Musicians SelectMusicianWithId(int id)
        {
            try
            {
                // Retrieve the musician with the provided ID
                Musicians _music =
                    (Musicians)(from music in Orm.bd.Musicians
                                where music.id == id
                                select music).FirstOrDefault();

                return _music;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm SelectMusicianWithId: {ex.Message}");
                return null; // Return null if musician is not found
            }
        }

        /// <summary>
        /// Retrieves a local venue based on its ID.
        /// </summary>
        /// <param name="id">The ID of the local venue to retrieve.</param>
        /// <returns>The local venue matching the provided ID, or null if not found.</returns>
        public static Locals SelectLocalWithId(int id)
        {
            try
            {
                // Retrieve the local venue with the provided ID
                Locals _local =
                    (Locals)(from local in Orm.bd.Locals
                             where local.id == id
                             select local).FirstOrDefault();

                return _local;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm SelectLocalWithId: {ex.Message}");
                return null; // Return null if local is not found
            }
        }

        /// <summary>
        /// Inserts a new musician into the Musicians table.
        /// </summary>
        /// <param name="_music">The musician to insert into the database.</param>
        public static void InsertMusician(Musicians _music)
        {
            try
            {
                // Add the new musician and save the changes to the database
                Orm.bd.Musicians.Add(_music);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm InsertMusician: {ex.Message}");
            }
        }

        /// <summary>
        /// Inserts a new local venue into the Locals table.
        /// </summary>
        /// <param name="_local">The local venue to insert into the database.</param>
        public static void InsertLocal(Locals _local)
        {
            try
            {
                // Add the new local venue and save the changes to the database
                Orm.bd.Locals.Add(_local);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm InsertLocal: {ex.Message}");
            }
        }

        /// <summary>
        /// Marks a musician as inactive by updating their active status.
        /// </summary>
        /// <param name="_music">The musician to deactivate.</param>
        public static void DeleteUserMusician(UserMusician _music)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == _music.id);

                if (existingUser != null)
                {
                    existingUser.active = false; // Mark the musician as inactive
                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user musician with ID {_music.id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm DeleteUserMusician: {ex.Message}");
            }
        }

        /// <summary>
        /// Marks a local venue as inactive by updating their active status.
        /// </summary>
        /// <param name="_local">The local venue to deactivate.</param>
        public static void DeleteUserLocal(UserLocal _local)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == _local.id);

                if (existingUser != null)
                {
                    existingUser.active = false; // Mark the local venue as inactive
                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user local with ID {_local.id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm DeleteUserLocal: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates a musician's details without changing their password.
        /// </summary>
        /// <param name="id">The ID of the musician to update.</param>
        /// <param name="name">The updated name of the musician.</param>
        /// <param name="email">The updated email address of the musician.</param>
        /// <param name="description">The updated description of the musician.</param>
        /// <param name="userGenres">The updated list of genres for the musician.</param>
        /// <param name="lang">The updated language of the musician's songs.</param>
        /// <param name="price">The updated price of the musician.</param>
        /// <param name="size">The updated size of the musician.</param>
        public static void UpdateMusicianWithoutPass(int id, string name, string email, string description, List<Genres> userGenres, Languages lang, int price, int size)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == id && user.active == true);
                var existingMusician = Orm.bd.Musicians.FirstOrDefault(musician => musician.id == id);

                if (existingUser != null && existingMusician != null)
                {
                    // Update musician and user details without changing password
                    existingUser.name = name;
                    existingUser.email = email;
                    existingUser.description = description;
                    existingUser.Genres = userGenres;

                    existingMusician.price = price;
                    existingMusician.size = (byte)size;
                    existingMusician.songs_lang = lang.id;

                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user or musician with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm UpdateMusicianWithoutPass: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates a musician's details, including their password.
        /// </summary>
        /// <param name="id">The ID of the musician to update.</param>
        /// <param name="name">The updated name of the musician.</param>
        /// <param name="email">The updated email address of the musician.</param>
        /// <param name="description">The updated description of the musician.</param>
        /// <param name="userGenres">The updated list of genres for the musician.</param>
        /// <param name="lang">The updated language of the musician's songs.</param>
        /// <param name="price">The updated price of the musician.</param>
        /// <param name="size">The updated size of the musician.</param>
        /// <param name="pass">The updated password for the musician.</param>
        public static void UpdateMusician(int id, string name, string email, string description, List<Genres> userGenres, Languages lang, int price, int size, string pass)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == id && user.active == true);
                var existingMusician = Orm.bd.Musicians.FirstOrDefault(musician => musician.id == id);

                if (existingUser != null && existingMusician != null)
                {
                    // Update musician and user details, including password
                    existingUser.name = name;
                    existingUser.email = email;
                    existingUser.password = pass;
                    existingUser.description = description;
                    existingUser.Genres = userGenres;

                    existingMusician.price = price;
                    existingMusician.size = (byte)size;
                    existingMusician.songs_lang = lang.id;

                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user or musician with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm UpdateMusician: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates a local venue's details without changing their password.
        /// </summary>
        /// <param name="id">The ID of the local venue to update.</param>
        /// <param name="name">The updated name of the local venue.</param>
        /// <param name="email">The updated email address of the local venue.</param>
        /// <param name="description">The updated description of the local venue.</param>
        /// <param name="userGenres">The updated list of genres for the local venue.</param>
        /// <param name="capacity">The updated capacity of the venue.</param>
        /// <param name="yCoord">The updated Y-coordinate of the venue's location.</param>
        /// <param name="xCoord">The updated X-coordinate of the venue's location.</param>
        internal static void UpdateLocalWithoutPass(int id, string name, string email, string description, List<Genres> userGenres, int capacity, double yCoord, double xCoord)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == id && user.active == true);
                var existingLocal = Orm.bd.Locals.FirstOrDefault(local => local.id == id);

                if (existingUser != null && existingLocal != null)
                {
                    // Update local venue and user details without changing password
                    existingUser.name = name;
                    existingUser.email = email;
                    existingUser.description = description;
                    existingUser.Genres = userGenres;

                    existingLocal.capacity = capacity;
                    existingLocal.x_coordination = xCoord;
                    existingLocal.y_coordination = yCoord;

                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user or local with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm UpdateLocalWithoutPass: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates a local venue's details, including their password.
        /// </summary>
        /// <param name="id">The ID of the local venue to update.</param>
        /// <param name="name">The updated name of the local venue.</param>
        /// <param name="email">The updated email address of the local venue.</param>
        /// <param name="description">The updated description of the local venue.</param>
        /// <param name="userGenres">The updated list of genres for the local venue.</param>
        /// <param name="capacity">The updated capacity of the venue.</param>
        /// <param name="yCoord">The updated Y-coordinate of the venue's location.</param>
        /// <param name="xCoord">The updated X-coordinate of the venue's location.</param>
        /// <param name="pass">The updated password for the local venue.</param>
        internal static void UpdateLocal(int id, string name, string email, string description, List<Genres> userGenres, int capacity, double yCoord, double xCoord, string pass)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == id && user.active == true);
                var existingLocal = Orm.bd.Locals.FirstOrDefault(local => local.id == id);

                if (existingUser != null && existingLocal != null)
                {
                    // Update local venue and user details, including password
                    existingUser.name = name;
                    existingUser.email = email;
                    existingUser.password = pass;
                    existingUser.description = description;
                    existingUser.Genres = userGenres;

                    existingLocal.capacity = capacity;
                    existingLocal.x_coordination = xCoord;
                    existingLocal.y_coordination = yCoord;

                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in UsersOrm user or local with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm UpdateLocal: {ex.Message}");
            }
        }
    }
}
