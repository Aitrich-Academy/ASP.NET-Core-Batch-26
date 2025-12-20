using EmployeeManagement_Repo.Models;
using EmployeeManagement_Repo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement_Repo.Pages
{
    public class DetailsModel : PageModel
    {

        private readonly IEmployeeService _employeeService;
        public DetailsModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [BindProperty]
        public Employee employee {  get; set; }
        public async Task<IActionResult> OnGetAsync( int id)
        {
            employee=await _employeeService.GetEmployeeById(id);
            return Page();
        }
    }
}
