using AddProfile.Data;
using AddProfile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddProfile.Pages
{
    public class EditProfileModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditProfileModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty] public User Input { get; set; }

        public void OnGet()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId != null)
            {
                Input = _db.Users.FirstOrDefault(u => u.Id == userId);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId != null)
            {
                var dbUser = _db.Users.FirstOrDefault(u => u.Id == userId);
                if (dbUser != null)
                {
                    dbUser.FirstName = Input.FirstName;
                    dbUser.LastName = Input.LastName;
                    await _db.SaveChangesAsync();
                }
            }
            return RedirectToPage("/Profile");
        }
    }
}
