using WebAPI_Sample2.Models;

namespace WebAPI_Sample2.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(int id);
    }
}
