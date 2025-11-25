using Microsoft.EntityFrameworkCore;
using Service_Repo_Model.Models;
namespace Service_Repo_Model.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
