using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Models
{
    public class LibraryDbContext:DbContext
    {
        public DbSet<BookModel> BookTable { get; set; }
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
    }
}
