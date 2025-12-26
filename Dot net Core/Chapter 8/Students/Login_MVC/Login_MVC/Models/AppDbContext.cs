using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace Login_MVC.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
