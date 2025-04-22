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

        public static List<UserLocal> SelectLocals()
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

        public static void InsertUser(Users _user)
        {
            Orm.bd.Users.Add(_user);
            Orm.bd.SaveChanges();
        }

        public static Users SelectUserWithMail(string email)
        {
            Users _user =
                (Users)(from user in Orm.bd.Users
                        where user.email == email && user.active == true
                        select user).FirstOrDefault();

            return _user;
        }

        public static Musicians SelectMusicianWithId(int id)
        {
            Musicians _music =
                (Musicians)(from music in Orm.bd.Musicians
                        where music.id == id
                        select music).FirstOrDefault();

            return _music;
        }
        public static Locals SelectLocalWithId(int id)
        {
            Locals _local =
                (Locals)(from local in Orm.bd.Locals
                            where local.id == id
                            select local).FirstOrDefault();

            return _local;
        }

        public static void InsertMusician(Musicians _music)
        {
            Orm.bd.Musicians.Add(_music);
            Orm.bd.SaveChanges();
        }

        public static void InsertLocal(Locals _local)
        {
            Orm.bd.Locals.Add(_local);
            Orm.bd.SaveChanges();
        }

        public static void DeleteUserMusician(UserMusician _music)
        {
            var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == _music.id);

            if (existingUser != null)
            {
                existingUser.active = false;

                Orm.bd.SaveChanges();
            }
        }
        public static void DeleteUserLocal(UserLocal _local)
        {
            var existingUser = Orm.bd.Users.FirstOrDefault(user => user.id == _local.id);

            if (existingUser != null)
            {
                existingUser.active = false;

                Orm.bd.SaveChanges();
            }
        }

        public static void UpdateMusicianWithoutPass(int id, string name, string email, string description, List<Genres> userGenres, Languages lang, int price, int size)
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
        }

        public static void UpdateMusician(int id, string name, string email, string description, List<Genres> userGenres, Languages lang, int price, int size, string pass)
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
        }

        internal static void UpdateLocalWithoutPass(int id, string name, string email, string description, List<Genres> userGenres, int capacity, double yCoord, double xCoord)
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
        }

        internal static void UpdateLocal(int id, string name, string email, string description, List<Genres> userGenres, int capacity, double yCoord, double xCoord, string pass)
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
        }
    }
}
