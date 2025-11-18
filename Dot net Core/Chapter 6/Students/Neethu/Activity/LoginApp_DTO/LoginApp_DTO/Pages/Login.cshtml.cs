using LoginApp_DTO.Data;
using LoginApp_DTO.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginApp_DTO.Pages
{
    public class LoginModel : PageModel
    {
        private readonly LoginAppDbContext _db;

        public LoginModel(LoginAppDbContext db)
        {
            _db=db;
        }

        [BindProperty]
        public LoginDto Input { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var user=_db.Users.FirstOrDefault(u=>u.Email==Input.Email&&u.Password==Input.Password);
            if (user!=null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetString("UserName", user.FirstName);
                return RedirectToPage("/Home");
                
            }
            else
            {
                ErrorMessage = "Invalid Email or Password";
                return Page();
            }
        }
    }
}
