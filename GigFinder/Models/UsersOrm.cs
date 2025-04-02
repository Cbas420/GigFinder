using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                        where user.email == email
                        select user).FirstOrDefault();

            return _user;
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
    }
}
