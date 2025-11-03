using CFA_EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFA_EF.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-FAPBG4Q0;Initial Catalog=CFA;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
