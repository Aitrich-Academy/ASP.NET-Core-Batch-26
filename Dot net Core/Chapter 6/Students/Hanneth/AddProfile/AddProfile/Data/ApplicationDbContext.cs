using AddProfile.Models;
using Microsoft.EntityFrameworkCore;

namespace AddProfile.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
