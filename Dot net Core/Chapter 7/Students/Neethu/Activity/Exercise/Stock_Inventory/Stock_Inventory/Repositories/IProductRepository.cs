using Stock_Inventory.Data.Models;

namespace Stock_Inventory.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task<List<Product>> GetProductsByCategoryAsync(string category);
        Task<Product> GetProductByIdAsync(int id);
    }
}
