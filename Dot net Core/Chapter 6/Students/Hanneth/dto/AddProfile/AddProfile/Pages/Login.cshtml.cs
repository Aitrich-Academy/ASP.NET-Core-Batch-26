using AddProfile.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AddProfile.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string ErrorMessage {  get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var user=_context.users.FirstOrDefault(u=>u.Email==Email&&u.Password==Password);
            if(user!=null)
            {
                HttpContext.Session.SetInt32("UserId", user.id);
                HttpContext.Session.SetString("UserName", user.FirstName);
                return RedirectToPage("/Dashboard");
            }
            ErrorMessage = "Invalid email or password";
            return Page();
        }
    }
}
