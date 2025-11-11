using Microsoft.EntityFrameworkCore;
using System;

namespace Razor_Crud1.Models
{
    public class RazorDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public RazorDbContext(DbContextOptions<RazorDbContext> options) : base(options)
        {
        }

    }
}
