using CFA_Employee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFA_Employee.Data
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Employee> employees {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-FAPBG4Q0;Initial Catalog=CFA;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
