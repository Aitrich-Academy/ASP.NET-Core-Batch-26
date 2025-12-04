using JobPortal.Models;
using JobPortal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortal.Pages.JobSeeker
{
    public class LoginModel : PageModel
    {
        private readonly IUserService service;

        public LoginModel(IUserService service)
        {
            this.service = service;
        }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var user=service.Login(Email, Password);
            if(user!=null)
            {
                HttpContext.Session.SetInt32("UserId",user.Id);
                HttpContext.Session.SetString("UserName", user.FirstName);
                return RedirectToPage("/JobSeeker/DashBoard");
            }
            ErrorMessage = "Invalid Credentials";
            return Page();
        }
    }
}
