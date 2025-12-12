
using Login_DTO.Data;
using Login_DTO.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login_dto.Pages
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContextcs _db;

        public LoginModel(AppDbContextcs db)
        {
            _db = db;
        }

        [BindProperty]
        public Logindto Input { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == Input.Email && u.Password == Input.Password);
            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetString("UserName", user.FirstName);
                return RedirectToPage("/Home");
            }

            ErrorMessage = "Invalid email or password.";
            return Page();
        }
    }
}
