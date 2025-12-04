using Microsoft.EntityFrameworkCore;

namespace JobPortal.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<JobApplication> Applications { get; set; }
    }
}
