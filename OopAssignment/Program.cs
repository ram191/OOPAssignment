using System;
using System.Collections.Generic;
using System.Linq;

namespace OopAssignment
{
    class Program                                                                                                             
    {
        static void Main(string[] args)
        {
            //Test Number 1
            Console.WriteLine(Hash.md5("testhash"));
            Console.WriteLine(Hash.sha1("testhash"));
            Console.WriteLine(Hash.sha256("testhash"));
            Console.WriteLine(Hash.sha512("testhash"));

            //Test Number 2
            var message = CipherClass.encrypt("hahaha", "password");
            Console.WriteLine(message);
            var decrypt = CipherClass.decrypt(message, "salahpassword");
            Console.WriteLine(decrypt);

            //Test Number 3
            LogClass.PopulateErrorLog();
            LogClass.SaveAllErrorLog();

            //Test Number 4
            Auth.PopulateUser();
            Auth.Login("ram191", "password");
            Auth.Validate("ram191", "123456");
            Auth.User();
            Auth.Id();
            Auth.Check();
            Auth.LogOut();
            Auth.Guest();
            Auth.LastLogin();


            //Test Number 5
            Cart newcart = new Cart();

            newcart.AddItem(2, 10000, 2)
                .AddItem(3, 10000, 3)
                .AddItem(4, 10000, 4)
                .RemoveItem(2)
                .AddDiscount(50);

            Console.WriteLine(Cart.TotalItems());
            Console.WriteLine(Cart.TotalQuantity());
            Console.WriteLine(Cart.TotalPrice());
            Cart.ShowAllItems();
            Cart.Checkout();
        }
    }


}
