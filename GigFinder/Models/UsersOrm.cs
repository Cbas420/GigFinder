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
    }
}
