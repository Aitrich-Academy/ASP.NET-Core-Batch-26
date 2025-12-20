using Stock_Inventory.Data.Models;

namespace Stock_Inventory.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<bool> AddProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int id);
        Task<List<Product>> GetProductsByCategoryAsync(string category);
        Task<Product> GetProductByIdAsync(int id);
    }
}
