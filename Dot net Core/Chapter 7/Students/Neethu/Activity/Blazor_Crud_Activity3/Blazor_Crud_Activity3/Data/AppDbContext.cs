using Blazor_Crud_Activity3.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Crud_Activity3.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
