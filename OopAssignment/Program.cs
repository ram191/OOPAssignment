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

            //var decrypt = CipherClass.decrypt(message, "password");
            //Console.WriteLine(message);

            //Auth.Login("ram191", "123456");
            //Auth.LastLogin();
            //List<Cart> itemCart = new List<Cart>();

            Cart newcart = new Cart();

            newcart.AddItem(2, 20000, 2)
                .AddItem(3, 30000, 3)
                .AddItem(4, 131313, 4);

            Console.WriteLine(Cart.TotalItems());
        }
    }


}
