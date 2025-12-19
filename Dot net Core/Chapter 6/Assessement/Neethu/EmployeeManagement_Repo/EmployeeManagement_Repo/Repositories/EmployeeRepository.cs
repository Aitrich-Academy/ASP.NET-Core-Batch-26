using EmployeeManagement_Repo.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement_Repo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        public readonly EmployeeDbContext context;
        public EmployeeRepository(EmployeeDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await context.Employees.ToListAsync();
        }
        public async Task<List<Employee>> GetEmployeeByDesignation(string desig)
        {
            //return await context.Employees.Where(e=>e.Designation==desig).ToListAsync();    
            return await context.Employees.Where(e=>e.Designation.Contains(desig)).ToListAsync();
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            context.Employees.Add(employee);
            await context.SaveChangesAsync();

        }
        public async Task<Employee> GetEmployeeById(int id)
        {
            return await context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
