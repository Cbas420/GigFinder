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
            try
            {
                UsersDesktop _userDesktop =
                    (UsersDesktop)(from user in Orm.bd.UsersDesktop
                                   where user.email == email && user.password == password && user.active == true
                                   select user).FirstOrDefault();

                return _userDesktop;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersDesktop Selectlogin: {ex.Message}");
                return null;
            }
        }

        public static List<UsersDesktop> SelectGlobal()
        {
            try
            {
                List<UsersDesktop> _usersDesktops = (
                    from users in Orm.bd.UsersDesktop
                    where users.active == true
                    select users).ToList();

                return _usersDesktops;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersDesktop SelectGlobal: {ex.Message}");
                return new List<UsersDesktop>();
            }
        }

        public static UsersDesktop SelectWithMail(string email)
        {
            try
            {
                UsersDesktop _userDesktop =
                    (UsersDesktop)(from user in Orm.bd.UsersDesktop
                                   where user.email == email && user.active == true
                                   select user).FirstOrDefault();

                return _userDesktop;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersDesktop SelectWithMail: {ex.Message}");
                return null;
            }
        }

        public static void Insert(UsersDesktop _userDesktop)
        {
            try
            {
                Orm.bd.UsersDesktop.Add(_userDesktop);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersDesktop Insert: {ex.Message}");
            }
        }

        public static void Delete(UsersDesktop _userDesktop)
        {
            try
            {
                var existingUser = Orm.bd.UsersDesktop.FirstOrDefault(user => user.id == _userDesktop.id);
                if (existingUser != null)
                {
                    existingUser.active = false;
                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in UsersDesktop user with ID {_userDesktop.id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersDesktop Delete: {ex.Message}");
            }
        }

        public static void Update(UsersDesktop _userDesktop)
        {
            try
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
                else
                {
                    Console.WriteLine($"Error in UsersDesktop user with ID {_userDesktop.id} not found for update.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersDesktop Update: {ex.Message}");
            }
        }

        public static void UpdateWithoutPass(UsersDesktop _userDesktop)
        {
            try
            {
                var existingUser = Orm.bd.UsersDesktop.FirstOrDefault(user => user.id == _userDesktop.id);
                if (existingUser != null)
                {
                    existingUser.name = _userDesktop.name;
                    existingUser.surname = _userDesktop.surname;
                    existingUser.email = _userDesktop.email;
                    existingUser.type = _userDesktop.type;

                    Orm.bd.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Error in UsersDesktop user with ID {_userDesktop.id} not found for update without password.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersDesktop UpdateWithoutPass: {ex.Message}");
            }
        }
    }
}
