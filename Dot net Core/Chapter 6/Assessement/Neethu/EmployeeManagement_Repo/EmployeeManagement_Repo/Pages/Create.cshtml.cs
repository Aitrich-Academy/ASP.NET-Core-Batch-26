using EmployeeManagement_Repo.Models;
using EmployeeManagement_Repo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement_Repo.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IEmployeeService _employeeService;
        public CreateModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [BindProperty]
        public Employee Input { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                await _employeeService.AddEmployeeAsync(Input);
                return RedirectToPage("Index");
            }
        }
    }
}
