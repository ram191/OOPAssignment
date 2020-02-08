using System;
using System.Collections.Generic;

namespace OopAssignment
{
    public class Auth
    {
        public static bool isLoggedIn = false;
        static int userId;
        public static DateTime lastLoggedIn;
        private static List<User> userList = new List<User>();

        public static void Login(string name, string password)
        {
            bool IsExist = false;
            foreach (var u in userList)
            {
                if (u.Username == name && u.Password == password)
                {
                    Console.WriteLine("You are now logged in!");
                    isLoggedIn = true;
                    userId = u.Id;
                    
                    IsExist = true;
                }
                else if(u.Username == name)
                {
                    Console.WriteLine("Wrong password. Please try again");
                    IsExist = true;
                }
            }
            if (IsExist == false)
            {
                string message = "User does not exist. Please Register.";
                Console.WriteLine(message);
                DateTime date = DateTime.Now;
                LogClass.errorLog.Add(new ErrorLog { Date = date, Message = message });
            }
            IsExist = false;
        }

        public static void Validate(string name, string password)
        {
            bool IsExist = false;
            foreach (var u in userList)
            {
                if (u.Username == name && u.Password == password)
                {
                    Console.WriteLine($"Your username is {name} and your username is {password}");
                    IsExist = true;
                }
                else if (u.Username == name)
                {
                    Console.WriteLine("Wrong password. Please try again");
                    IsExist = true;
                }
            }
            if (IsExist == false)
            {
                string message = "User does not exist. Please Register.";
                Console.WriteLine(message);
                DateTime date = DateTime.Now;
                LogClass.errorLog.Add(new ErrorLog { Date = date, Message = message });
            }
        }

        public static void LogOut()
        {
            Console.WriteLine("You are successfully logged out");
            isLoggedIn = false;
            userId = 0;
        }

        public static void Id()
        {
            if(!isLoggedIn)
            {
                Console.WriteLine("You are not logged in. Please log in first");
            }
            else
            {
                Console.WriteLine($"Your ID is {userId}");
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
        public static void PopulateUser()
        {
            userList.Add(new User { Username = "ram191", Password = "password", Id = 1, FirstName = "rayhan", LastName = "muhammad", Email = "ali_rayhan19@hotmail.com"});
        }
    }
}
