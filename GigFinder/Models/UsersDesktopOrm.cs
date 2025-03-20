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
    }
}
