using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_System
{
    public class Cart
    {
        public string ItemName { get; private set; }
        public decimal Price { get;private set; }
        public int Quantity { get; private set; }

        public Cart(string itemName, decimal price, int quantity    )
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }
    }
}
