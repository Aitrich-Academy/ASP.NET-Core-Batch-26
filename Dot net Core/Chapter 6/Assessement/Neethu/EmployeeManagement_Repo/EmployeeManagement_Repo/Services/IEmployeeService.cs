using EmployeeManagement_Repo.Models;

namespace EmployeeManagement_Repo.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployees();
        Task<List<Employee>> GetEmployeeByDesignation(string desig);
        Task AddEmployeeAsync(Employee employee);

        Task<Employee> GetEmployeeById(int id);
    }
}
