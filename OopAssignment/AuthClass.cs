using System;
namespace OopAssignment
{
    public class Auth : User
    {
        public static bool isLoggedIn = false;
        public static DateTime lastLoggedIn;

        public static void Login(string name, string password)
        {
            {
                if (name == "ram191" && password == "123456")
                {
                    isLoggedIn = true;
                    Console.WriteLine("You are now logged in!");
                    lastLoggedIn = DateTime.Now;

                }
                else
                {
                    Console.WriteLine("Username or Password invalid!");
                }
            }
        }

        public static void Validate(string name, string password)
        {
            Console.WriteLine($"Your username is {name} and your password is {password}");
        }

        public static void LogOut()
        {
            isLoggedIn = false;
        }

        public static void Id()
        {
            if(!isLoggedIn)
            {
                Console.WriteLine("You are not logged in. Please log in first");
            }
            else
            {
                Console.WriteLine($"Your ID is");
            }
        }

        public static void Check()
        {
            isLoggedIn = true ? true : false;
        }

        public static void Guest()
        {
            isLoggedIn = true ? false : true;
        }

        public static void LastLogin()
        {
            Console.WriteLine(lastLoggedIn);
        }
    }
}
