using EmployeeManagement_Repo.Models;
using EmployeeManagement_Repo.Repositories;

namespace EmployeeManagement_Repo.Services
{
    public class EmployeeService: IEmployeeService
    {

        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await repo.GetAllEmployees();
        }

        public async Task<List<Employee>> GetEmployeeByDesignation(string desig)
        {
            var employees= await repo.GetEmployeeByDesignation(desig);
            return employees;
        }
        public async Task AddEmployeeAsync(Employee employee)
        {
            await repo.AddEmployeeAsync(employee);
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await repo.GetEmployeeById(id);
        }
    }
}
