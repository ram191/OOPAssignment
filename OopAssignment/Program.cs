using System;
using System.Collections.Generic;
using System.Linq;

namespace OopAssignment
{
    class Program                                                                                                             
    {
        static void Main(string[] args)
        {
            //var message = CipherClass.encrypt("hahaha", "password");
            //Console.WriteLine(message);
            //var decrypt = CipherClass.decrypt(message, "salahpassword");

            //Auth.Login("ram191", "123456");
            //Auth.LastLogin();
            //List<Cart> itemCart = new List<Cart>();

            //Cart newcart = new Cart();

            //newcart.AddItem(2, 10000, 2)
            //    .AddItem(3, 10000, 3)
            //    .AddItem(4, 10000, 4)
            //    .RemoveItem(2)
            //    .AddDiscount(50);

            //Console.WriteLine(Cart.TotalPrice());

            Auth.PopulateUser();
            Auth.Login("riski", "123456");
            LogClass.SaveAllErrorLog();
        }
    }


}
