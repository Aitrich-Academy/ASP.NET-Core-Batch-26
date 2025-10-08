using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class ShoppingCart
    {
        List<Item> items=new List<Item>
        {
            new Item("Apple",100,2),new Item("Orange",50,1),new Item("Grapes",80,1),new Item("Milk",26,3)
        };
        public void AddItem()
        {
            Console.WriteLine("Enter the item to add");
            string itemname=Console.ReadLine();
            Console.WriteLine("Please enter the rate of the item");
            decimal itemprice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the quantity");
            decimal itemquantity =Convert.ToDecimal(Console.ReadLine());
            items.Add(new Item(itemname,itemprice,itemquantity));
            Console.WriteLine("Item added sucessfully");
            
        }
        public void RemoveItem()
        {
            Console.WriteLine("Enter item name to be removed");
            string itemname= Console.ReadLine();
            try
            {
                Item itemremove = items.FirstOrDefault(a => a.Name == itemname);
                if (itemremove != null)
                {
                    items.Remove(itemremove);
                    Console.WriteLine($"{itemremove} have removed from cart");
                }

            }
            catch (Exception ex) { Console.WriteLine("Item not found",ex.Message); }
        }
        public decimal CalculateTotalPrice()
        {
            decimal Total = 0;
            foreach (var i in items)
            {
                Total += i.Price * i.Quantity;   
             }
            Console.WriteLine($"Total price is : {Total}");
            return Total;
        }
       
        public void Discount()
        {
            decimal discount,Final=0;
            decimal Total = CalculateTotalPrice();
            Console.WriteLine(Total);
            discount = Total*(decimal)0.10;
            Console.WriteLine(discount);
            Final = Total - discount;
            Console.WriteLine($"Total price after discount is : {Final}");
        }
    }
}
