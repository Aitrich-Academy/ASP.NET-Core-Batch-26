using WebAPI_Sample2.Models;

namespace WebAPI_Sample2.Services
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(int id);
    }
}
