using System;

namespace UserValidationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string username = GetUsername();
                string password = GetPassword();

                Console.WriteLine($"User {username} successfully created.");
            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static string GetUsername()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            if (string.IsNullOrEmpty(username) || username.Length < 5)
            {
                throw new InvalidUsernameException("Username must be at least 5 letters long.");
            }

            return username;
        }

        static string GetPassword()
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                throw new InvalidPasswordException("Password must be at least 8 letters long.");
            }

            bool containsDigit = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    containsDigit = true;
                    break;
                }
            }

            if (!containsDigit)
            {
                throw new InvalidPasswordException("Password must contain at least one letter.");
            }

            return password;
        }
    }
}

