using Shopping_Cart;

internal class Program
{
    private static void Main(string[] args)
    {
        Item item = new Item();
        ShoppingCart cart = new ShoppingCart();
       bool exitProgram=false;
        do
        {
            Console.WriteLine(" 1.Add Item");
            Console.WriteLine(" 2.Remove Item");
            Console.WriteLine(" 3.Apply Discount");
            Console.WriteLine(" 4.Display Total Price");
            Console.WriteLine(" 5.Exit");
            Console.WriteLine();
            Console.WriteLine(" Please select a choice");
            string input=Console.ReadLine();
            switch (input)
            {
                case "1":
                    cart.AddItem();
                    break;
                case "2": cart.RemoveItem(); break;
                case "3": cart.Discount(); break;
                case "4": cart.CalculateTotalPrice(); break;
                case "5": exitProgram = true; break;
            }

        }while (exitProgram==false);

        }
}