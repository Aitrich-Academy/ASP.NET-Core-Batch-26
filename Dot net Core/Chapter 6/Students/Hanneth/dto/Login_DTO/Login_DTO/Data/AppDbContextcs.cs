using Login_DTO.Model;
using Microsoft.EntityFrameworkCore;

namespace Login_DTO.Data
{
    public class AppDbContextcs : DbContext
    {
        public AppDbContextcs(DbContextOptions<AppDbContextcs> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
