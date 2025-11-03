using CFA_FOREIGNKEY.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFA_FOREIGNKEY.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-FAPBG4Q0;Initial Catalog=CFA_EF;Integrated Security=True;Trust Server Certificate=True;");
        }
    }
}
