using EmployeeManagement_Repo.Models;
using EmployeeManagement_Repo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement_Repo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeService _employeeService;
        public IndexModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [BindProperty]
        public string Search {  get; set; }
        [BindProperty]
        public int TotalCount { get; set; }
        public List<Employee> employees { get; set; }
        public async Task OnGetAsync()
        {
           
                employees=await _employeeService.GetAllEmployees();
               
            TotalCount=employees.Count();
        }
        public async Task OnPostAsync()
        {
            if (!string.IsNullOrEmpty(Search))
            {
                employees = await _employeeService.GetEmployeeByDesignation(Search);
                
            }
            else
            {
                employees = await _employeeService.GetAllEmployees();
               
            }
            TotalCount = employees.Count();
        }

    }
}
