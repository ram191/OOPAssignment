using System;

namespace OopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //var message = CipherClass.encrypt("hahaha", "password");

            //var decrypt = CipherClass.decrypt(message, "password");
            //Console.WriteLine(message);

            Auth.Login("ram191", "123456");
            Auth.LastLogin();
        }
    }


}
