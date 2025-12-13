using login.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace login.Pages
{
    public class LoginModel : PageModel
    {
        public readonly AppDbContext _context;
        public LoginModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string ErrorMessage {  get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var User = _context.users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
            if (User != null)
            {
                HttpContext.Session.SetInt32("UserId", User.Id);
                HttpContext.Session.SetString("UserId", User.FirstName);
                return RedirectToPage("/Home");
            }
            ErrorMessage = "Invalid id or password";
            return Page();
        }
    }
}
