using Assessment.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assessment.Pages
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;
        public LoginModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string errormessage {  get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var user=_context.Users.FirstOrDefault(u=>u.Email == Email&&u.Password==Password);
            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.UserId);
                HttpContext.Session.SetString("Usename", user.FirstName);
                HttpContext.Session.SetString("LastName",user.LastName);
                HttpContext.Session.SetString("Email", user.Email);
                    return RedirectToPage("/Dashboard");
            }
            errormessage = "Invalid credentials";
            return Page();
        }
    }
}
