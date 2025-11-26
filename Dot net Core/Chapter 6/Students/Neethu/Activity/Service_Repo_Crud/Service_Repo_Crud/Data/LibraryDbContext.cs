using Microsoft.EntityFrameworkCore;
using Service_Repo_Crud.Models;

namespace Service_Repo_Crud.Data
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Book> BookTable { get; set; }
    }
}
