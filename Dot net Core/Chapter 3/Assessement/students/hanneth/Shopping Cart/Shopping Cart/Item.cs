using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class Item
    {
        public string Name {  get; set; }
        public decimal Price {  get; set; }
        public decimal Quantity {  get; set; }
       public Item()
        { }
       public Item(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
