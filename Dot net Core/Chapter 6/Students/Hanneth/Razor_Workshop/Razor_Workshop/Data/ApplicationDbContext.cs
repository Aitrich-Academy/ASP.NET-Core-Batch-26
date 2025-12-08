using Microsoft.EntityFrameworkCore;
using Razor_Workshop.Model;

namespace Razor_Workshop.Data
{
    public class ApplicationDbContext:DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { } 
        public DbSet<Job> jobs { get; set; }
    }
}
