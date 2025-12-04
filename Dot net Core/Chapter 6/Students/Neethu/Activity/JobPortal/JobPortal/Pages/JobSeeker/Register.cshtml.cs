using JobPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPortal.Services;

namespace JobPortal.Pages.JobSeeker
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;

        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]

        public User Input { get; set; }

        public string Message { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            var success=_userService.RegisterUser(Input);
            if (!success)
            {
                Message = "Email Already Registered";
                return Page();
            }
            return RedirectToPage("/JobSeeker/Login");
        }
    }
}
