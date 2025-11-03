using CFA_EF.Data;
using CFA_EF.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {


            // Add a new product
            var newProduct = new Product { Name = "Biscuit", Price = 200 };
            context.Products.Add(newProduct);
            context.SaveChanges();
            Console.WriteLine("New Product Added!");

            // Fetch and display all products
            var products = context.Products.ToList();
            Console.WriteLine("Products in Database:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} - {product.Name} - ${product.Price}");
            }
        }
    }
}