using JobProvider_BlazorApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JobProvider_BlazorApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobProvider> JobProviders { get; set; }
    }
}
