using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace JobPortal_CompanyRegistration.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
