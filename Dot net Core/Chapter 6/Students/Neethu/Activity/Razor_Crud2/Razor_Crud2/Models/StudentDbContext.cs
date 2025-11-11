using Microsoft.EntityFrameworkCore;

namespace Razor_Crud2.Models
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDbContext(DbContextOptions options) : base(options) { }   
    }
}
