using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

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
        public static List<UserMusician> SelectMusicians()
        {
            try
            {
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
                return new List<UserMusician>();
            }
        }

        public static List<UserLocal> SelectLocals()
        {
            try
            {
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
                return new List<UserLocal>();
            }
        }

        public static void InsertUser(Users _user)
        {
            try
            {
                Orm.bd.Users.Add(_user);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm InsertUser: {ex.Message}");
            }
        }

        public static Users SelectUserWithMail(string email)
        {
            try
            {
                Users _user =
                    (Users)(from user in Orm.bd.Users
                            where user.email == email && user.active == true
                            select user).FirstOrDefault();

                return _user;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm SelectUserWithMail: {ex.Message}");
                return null;
            }
        }

        public static Musicians SelectMusicianWithId(int id)
        {
            try
            {
                Musicians _music =
                    (Musicians)(from music in Orm.bd.Musicians
                                where music.id == id
                                select music).FirstOrDefault();

                return _music;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm SelectMusicianWithId: {ex.Message}");
                return null;
            }
        }

        public static Locals SelectLocalWithId(int id)
        {
            try
            {
                Locals _local =
                    (Locals)(from local in Orm.bd.Locals
                             where local.id == id
                             select local).FirstOrDefault();

                return _local;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm SelectLocalWithId: {ex.Message}");
                return null;
            }
        }

        public static void InsertMusician(Musicians _music)
        {
            try
            {
                Orm.bd.Musicians.Add(_music);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm InsertMusician: {ex.Message}");
            }
        }

        public static void InsertLocal(Locals _local)
        {
            try
            {
                Orm.bd.Locals.Add(_local);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersOrm InsertLocal: {ex.Message}");
            }
        }

        public static void DeleteUserMusician(UserMusician _music)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == _music.id);

                if (existingUser != null)
                {
                    existingUser.active = false;
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

        public static void DeleteUserLocal(UserLocal _local)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == _local.id);

                if (existingUser != null)
                {
                    existingUser.active = false;
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

        public static void UpdateMusicianWithoutPass(int id, string name, string email, string description, List<Genres> userGenres, Languages lang, int price, int size)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == id && user.active == true);
                var existingMusician = Orm.bd.Musicians.FirstOrDefault(musician => musician.id == id);

                if (existingUser != null && existingMusician != null)
                {
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

        public static void UpdateMusician(int id, string name, string email, string description, List<Genres> userGenres, Languages lang, int price, int size, string pass)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == id && user.active == true);
                var existingMusician = Orm.bd.Musicians.FirstOrDefault(musician => musician.id == id);

                if (existingUser != null && existingMusician != null)
                {
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

        internal static void UpdateLocalWithoutPass(int id, string name, string email, string description, List<Genres> userGenres, int capacity, double yCoord, double xCoord)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == id && user.active == true);
                var existingLocal = Orm.bd.Locals.FirstOrDefault(local => local.id == id);

                if (existingUser != null && existingLocal != null)
                {
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

        internal static void UpdateLocal(int id, string name, string email, string description, List<Genres> userGenres, int capacity, double yCoord, double xCoord, string pass)
        {
            try
            {
                var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == id && user.active == true);
                var existingLocal = Orm.bd.Locals.FirstOrDefault(local => local.id == id);

                if (existingUser != null && existingLocal != null)
                {
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
