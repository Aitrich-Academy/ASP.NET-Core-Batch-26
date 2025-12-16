using Microsoft.EntityFrameworkCore;

namespace Activity_3.Data.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Book> Booksss { get; set; }
    }
}
