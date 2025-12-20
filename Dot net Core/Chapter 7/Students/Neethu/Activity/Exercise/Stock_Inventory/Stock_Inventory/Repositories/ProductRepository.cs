using Microsoft.EntityFrameworkCore;
using Stock_Inventory.Data;
using Stock_Inventory.Data.Models;

namespace Stock_Inventory.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly StockDbContext context;
        public ProductRepository(StockDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = await context.Products.ToListAsync();
            return products;
        }
       public async Task AddProductAsync(Product product)
        {
             context.Products.Add(product);
            await context.SaveChangesAsync();

        }
        public async Task UpdateProductAsync(Product product)
        {

            var existing = await context.Products.FindAsync(product.ProductId);
            if(existing != null)
            {
                context.Products.Update(product);
                await context.SaveChangesAsync();
            }
            
        }
        public async Task DeleteProductAsync(int id)
        {
            var product=await context.Products.FindAsync(id);
            if (product != null)
            {
                context.Products.Remove(product);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            return await context.Products.Where(p=>p.Category == category).ToListAsync();
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await context.Products.FindAsync(id);
        }
    }
}
