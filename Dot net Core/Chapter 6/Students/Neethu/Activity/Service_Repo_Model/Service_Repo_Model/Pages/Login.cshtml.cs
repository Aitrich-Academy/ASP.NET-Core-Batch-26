using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Model.Services;

namespace Service_Repo_Model.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _Service;

        public LoginModel(IUserService service)
        {
            _Service = service;
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
            var user=_Service.Login(Email, Password);
            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetString("UserName", user.FirstName);
                return RedirectToPage("DashBoard");
            }
            else
            {
                ErrorMessage = "Email Id or Password invalid";
                return Page();
            }
        }
    }
}
