using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement_Repo.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; } 
    }
}
