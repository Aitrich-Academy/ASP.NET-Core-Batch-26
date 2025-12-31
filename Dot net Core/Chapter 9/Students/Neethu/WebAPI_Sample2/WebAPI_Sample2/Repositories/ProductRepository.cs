using WebAPI_Sample2.Models;

namespace WebAPI_Sample2.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;
        public ProductRepository(AppDbContext context)
        {
            this.context = context;
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public Product GetById(int id)
        {
            return context.Products.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();

        }
        public void Update(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
           var product = context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
