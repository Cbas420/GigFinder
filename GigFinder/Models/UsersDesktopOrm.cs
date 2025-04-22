using System;
using System.Collections.Generic;
using System.Linq;

namespace GigFinder.Models
{
    public static class UsersDesktopOrm
    {
        /// <summary>
        /// Retrieves a user from the UsersDesktop table based on the provided email and password.
        /// </summary>
        /// <param name="email">The email address of the user to retrieve.</param>
        /// <param name="password">The password of the user to validate.</param>
        /// <returns>The user that matches the email and password, or null if no match is found.</returns>
        public static UsersDesktop Selectlogin(string email, string password)
        {
            try
            {
                // Retrieve a user matching the email and password
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

        /// <summary>
        /// Retrieves all active users from the UsersDesktop table.
        /// </summary>
        /// <returns>A list of all active users.</returns>
        public static List<UsersDesktop> SelectGlobal()
        {
            try
            {
                // Retrieve all active users
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

        /// <summary>
        /// Retrieves a user from the UsersDesktop table based on the provided email.
        /// </summary>
        /// <param name="email">The email address of the user to retrieve.</param>
        /// <returns>The user matching the email, or null if no match is found.</returns>
        public static UsersDesktop SelectWithMail(string email)
        {
            try
            {
                // Retrieve a user matching the email
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

        /// <summary>
        /// Inserts a new user into the UsersDesktop table.
        /// </summary>
        /// <param name="_userDesktop">The user to insert into the database.</param>
        public static void Insert(UsersDesktop _userDesktop)
        {
            try
            {
                // Add the new user to the UsersDesktop table
                Orm.bd.UsersDesktop.Add(_userDesktop);
                Orm.bd.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UsersDesktop Insert: {ex.Message}");
            }
        }

        /// <summary>
        /// Deactivates a user in the UsersDesktop table by setting their active status to false.
        /// </summary>
        /// <param name="_userDesktop">The user to deactivate.</param>
        public static void Delete(UsersDesktop _userDesktop)
        {
            try
            {
                var existingUser = Orm.bd.UsersDesktop.FirstOrDefault(user => user.id == _userDesktop.id);
                if (existingUser != null)
                {
                    existingUser.active = false; // Deactivate the user
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

        /// <summary>
        /// Updates the details of an existing user in the UsersDesktop table.
        /// </summary>
        /// <param name="_userDesktop">The user with updated details to save.</param>
        public static void Update(UsersDesktop _userDesktop)
        {
            try
            {
                var existingUser = Orm.bd.UsersDesktop.FirstOrDefault(user => user.id == _userDesktop.id);
                if (existingUser != null)
                {
                    // Update user details
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

        /// <summary>
        /// Updates the details of an existing user in the UsersDesktop table, without changing their password.
        /// </summary>
        /// <param name="_userDesktop">The user with updated details to save, excluding password.</param>
        public static void UpdateWithoutPass(UsersDesktop _userDesktop)
        {
            try
            {
                var existingUser = Orm.bd.UsersDesktop.FirstOrDefault(user => user.id == _userDesktop.id);
                if (existingUser != null)
                {
                    // Update user details without modifying the password
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
