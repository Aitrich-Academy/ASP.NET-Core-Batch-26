using Microsoft.EntityFrameworkCore;
using LoginApp_DTO.Models;

namespace LoginApp_DTO.Data
{
    public class LoginAppDbContext:DbContext
    {
        public LoginAppDbContext(DbContextOptions<LoginAppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
