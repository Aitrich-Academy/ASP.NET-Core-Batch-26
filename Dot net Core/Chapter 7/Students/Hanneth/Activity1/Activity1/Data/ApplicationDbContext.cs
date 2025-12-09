using Activity1.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Activity1.Data
{
    public class ApplicationDbContext:DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { }
        
      
        public DbSet<Book> books { get; set; }
    }
}
