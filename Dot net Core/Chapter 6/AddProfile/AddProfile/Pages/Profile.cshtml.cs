using AddProfile.Data;
using AddProfile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddProfile.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public ProfileModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public User User { get; set; }

        public void OnGet()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId != null)
            {
                User = _db.Users.FirstOrDefault(u => u.Id == userId);
            }
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/EditProfile");
        }
    }
}
