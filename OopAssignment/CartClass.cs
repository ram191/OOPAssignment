using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OopAssignment
{
    public class Cart : IItems
    {
        static string cartPath = @"D:\Programming\Refactory\OOPAssignment\OopAssignment\Cart.txt";
        public int Item_id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        static List<IItems> itemCart = new List<IItems>();

        public Cart AddItem(int id, int price, int qty = 1)
        {
            var obj = new Cart();
            obj.Item_id = id;
            obj.Price = price;
            obj.Quantity = qty;
            itemCart.Add(obj);
            return this;
        }

        public Cart RemoveItem(int id)
        {
            var obj = itemCart;
            var newObj = new List<IItems>();
            foreach (var x in obj)
            {
                if (x.Item_id != id)
                {
                    newObj.Add(x);
                }
            }
            itemCart = newObj;
            return this;
        }

        public Cart AddDiscount(int id)
        {
            var obj = itemCart;
            foreach (var x in obj)
            {
                x.Price = x.Price * id / 100;
            }
            itemCart = obj;
            return this;
        }

        public static int TotalItems()
        {
            return itemCart.Count();
        }

        public static int TotalQuantity()
        {
            int totalQty = 0;
            foreach(var x in itemCart)
            {
                totalQty += x.Quantity;
            }
            return totalQty;
        }

        public static int TotalPrice()
        {
            int totalPrice = 0;
            foreach (var x in itemCart)
            {
                totalPrice += x.Price * x.Quantity;
            }
            return totalPrice;
        }

        public static string ShowAllItems()
        {
            var allItems = new List<string>();
            foreach(var x in itemCart)
            {
                allItems.Add(x.Item_id.ToString());
            }
            allItems.Distinct();
            return String.Join(',', allItems);
        }

        public static void Checkout()
        {
            List<string> lines = new List<string>();

            lines.Add("Item_id,Price,Qty");

            foreach(var x in itemCart)
            {
                lines.Add($"{x.Item_id},{x.Price},{x.Quantity}");
            }
            File.WriteAllLines(cartPath, lines);
        }
    }

    public interface IItems
    {
        int Item_id { get; set; }
        int Price { get; set; }
        int Quantity { get; set; }
    }
}
