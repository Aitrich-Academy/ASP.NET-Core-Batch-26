using Stock_Inventory.Data.Models;
using Stock_Inventory.Repositories;

namespace Stock_Inventory.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository repo;
        public ProductService(IProductRepository repo)
        {
            this.repo = repo;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await repo.GetAllProductsAsync();
        }
        public async Task<bool> AddProductAsync(Product product)
        {
            await repo.AddProductAsync(product);
            return true;
        }
        public async Task<bool> UpdateProductAsync(Product product)
        {
            await repo.UpdateProductAsync(product);
            return true;
        }
        public async Task<bool> DeleteProductAsync(int id)
        {
             await repo.DeleteProductAsync(id);
            return true;
        }
        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            return await repo.GetProductsByCategoryAsync(category);
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await repo.GetProductByIdAsync(id);
        }
    }
}
