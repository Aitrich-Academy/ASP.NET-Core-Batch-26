using Microsoft.EntityFrameworkCore;
using ServiceRepo.Model;

namespace ServiceRepo.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) :base(options) 
        { 
        }
        public DbSet<User> users { get; set; }
    }
}
