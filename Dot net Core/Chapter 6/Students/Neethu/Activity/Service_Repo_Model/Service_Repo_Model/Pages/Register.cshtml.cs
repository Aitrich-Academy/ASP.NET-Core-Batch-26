using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Service_Repo_Model.Models;
using Service_Repo_Model.Services;

namespace Service_Repo_Model.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _service;

        public RegisterModel(IUserService service)
        {
            _service = service;
        }
        [BindProperty]
        public User Input { get; set; }

        public string Message { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var Success=_service.Register(Input);
            if(!Success)
            {
                Message = "Email already Registered";
                return Page();  
            }
            return RedirectToPage("/Login");
        }
    }
}
