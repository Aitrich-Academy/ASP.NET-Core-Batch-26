using Add_Profile.Models;
using Microsoft.EntityFrameworkCore;
namespace Add_Profile.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
