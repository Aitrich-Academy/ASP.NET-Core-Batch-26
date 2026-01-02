using WebAPI_Sample2.Models;
using WebAPI_Sample2.Repositories;

namespace WebAPI_Sample2.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }
        public Product GetById(int id)
        {
            return productRepository.GetById(id);
        }
        public void Add(Product product)
        {
            productRepository.Add(product);
        }
        public void Update(Product product)
        {
            productRepository.Update(product);
        }
        public void Delete(int id)
        {
            productRepository.Delete(id);   
        }
    }
}
