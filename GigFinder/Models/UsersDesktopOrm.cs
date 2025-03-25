using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public static class UsersDesktopOrm
    {
        public static UsersDesktop Selectlogin(string email, string password)
        {
            UsersDesktop _userDesktop =
                (UsersDesktop)(from user in Orm.bd.UsersDesktop
                 where user.email == email && user.password == password
                 select user).FirstOrDefault();

            return _userDesktop;
        }

        public static List<UsersDesktop> SelectGlobal()
        {
            List<UsersDesktop> _usersDesktops = (
                from users in Orm.bd.UsersDesktop
                select users).ToList();

            return _usersDesktops;
        }

        public static UsersDesktop SelectWithMail(string email)
        {
            UsersDesktop _userDesktop =
                (UsersDesktop)(from user in Orm.bd.UsersDesktop
                               where user.email == email
                               select user).FirstOrDefault();

            return _userDesktop;
        }

        public static void Insert(UsersDesktop _userDesktop)
        {
            Orm.bd.UsersDesktop.Add(_userDesktop);
            Orm.bd.SaveChanges();
        }

        public static void Delete(UsersDesktop _userDesktop)
        {
            Orm.bd.UsersDesktop.Remove(_userDesktop);
            Orm.bd.SaveChanges();
        }

        public static void Update(UsersDesktop _userDesktop)
        {
            var existingUser = Orm.bd.UsersDesktop.FirstOrDefault(user => user.id == _userDesktop.id);

            if (existingUser != null)
            {
                existingUser.name = _userDesktop.name;
                existingUser.surname = _userDesktop.surname;
                existingUser.email = _userDesktop.email;
                existingUser.password = _userDesktop.password;
                existingUser.type = _userDesktop.type;

                Orm.bd.SaveChanges();
            }
        }
    }
}
