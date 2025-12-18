using Microsoft.EntityFrameworkCore;
using Stock_Inventory.Data.Models;

namespace Stock_Inventory.Data
{
    public class StockDbContext:DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
