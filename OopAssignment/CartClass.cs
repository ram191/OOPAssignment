using System;
using System.Collections.Generic;
using System.Linq;

namespace OopAssignment
{
    public class Cart
    {
        public static IItems obj = new IItems();
        public static List<Cart> itemCart = new List<Cart>();

        public Cart AddItem(int id, int price, int qty = 1)
        {
            obj.Item_id = id;
            obj.Price = price;
            obj.Quantity = qty;
            itemCart.Add(this);
            return this;
        }

        public static int TotalItems()
        {
            return itemCart.Count();
        }

        public void TotalQuantity()
        {
            var x = itemCart
                .Select(x => x.Quantity)
                .Sum();
        }
    }

    public class IItems
    {
        public int Item_id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
