using ShoppingCart_System;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        ShoppingCart shoppingCart = new ShoppingCart();
        bool exitprogram=false;
        while(!exitprogram)
        {
            try
            {
                Console.WriteLine("1. Add Item to Cart");
                Console.WriteLine("2. Remove an item From the cart");
                Console.WriteLine("3. Total Price Calculation");
                Console.WriteLine("4. Item list in cart");
                Console.WriteLine("5. Exit");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Enter the Item Name");
                        string itemname = Console.ReadLine();
                        Console.WriteLine("Enter the Price for the item");
                        decimal price = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the number of quanity required");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Cart cart = new Cart(itemname, price, quantity);
                        shoppingCart.AddItem(cart);
                        break;
                    case "2":
                        Console.WriteLine("Enter the item name which you wish to remove from the cart");
                        string itemname1 = Console.ReadLine();
                        shoppingCart.RemoveItem(itemname1);
                        break;
                    case "3":
                        Console.WriteLine("Enter the Discount percentage");
                        decimal discount = Convert.ToDecimal(Console.ReadLine());
                        shoppingCart.TotalPriceCalculation(discount);
                        break;
                    case "4":
                        shoppingCart.DisplayCart();
                        break;
                    case "5":
                        exitprogram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                        


                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}