using Activity1_Direct.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Activity1_Direct.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {

        }
        public DbSet<Book> bookss{ get; set; }
    }
}