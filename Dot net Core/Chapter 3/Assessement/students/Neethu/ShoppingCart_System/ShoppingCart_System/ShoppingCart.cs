using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_System
{
    public class ShoppingCart
    {
        Dictionary<string,Cart> carts=new Dictionary<string,Cart>();
        public void AddItem(Cart cart)
        {
            if (cart != null)
            {
                carts.Add(cart.ItemName,cart);
                Console.WriteLine("Item added Successfully");

            }
            else
            {
                Console.WriteLine("Please add a valid item");
            }
        }
        public void RemoveItem(string itemname)
        {
            try
            {
                var itemfound = carts.FirstOrDefault(e => e.Key == itemname);
                if(carts.ContainsKey(itemname))
                {
                    carts.Remove(itemname);
                    Console.WriteLine("Item removed successfully");
                }
                else
                    throw new ItemNotFoundException("Item not found in the cart");

            }
            catch(ItemNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void TotalPriceCalculation( decimal discount)
        {
            try
            {
                decimal sum = 0;
                foreach (var cart in carts.Values)
                {
                    
                        sum = sum + (cart.Price * cart.Quantity);
                    
                    
                    
                }
                Console.WriteLine("Total Price before Discount" + sum);
                decimal dicountrate= discount / 100;
                decimal discountedPrice = sum - (sum * dicountrate);
                if (discountedPrice > 0)
                {
                    Console.WriteLine("Price after Discount" + discountedPrice);
                }
                else
                    throw new PriceNegativeException("Total Price can't be negative.Update discount percentage");
            }
            catch(PriceNegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DisplayCart()
        {
            foreach (var cart in carts)
            {
                Console.WriteLine($"Item name {cart.Key}");
            }
        }
    }
    
}
