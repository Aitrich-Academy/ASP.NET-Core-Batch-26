using AddProfile.Data;
using AddProfile.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddProfile.Pages
{
    public class EditProfileModel : PageModel
    {
        private readonly ApplicationDbContext _context;

       public EditProfileModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public User Input { get; set; }

        public void OnGet()
        {
            var UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId != null)
            {
                Input = _context.users.FirstOrDefault(u => u.id == UserId);
            }
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var UserId= HttpContext.Session.GetInt32("UserId");
            if (UserId != null)
            {
                var dbUser = _context.users.FirstOrDefault(u => u.id == UserId);
                if (dbUser != null)
                {
                    dbUser.FirstName = Input.FirstName;
                    dbUser.LastName = Input.LastName;
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToPage("/Profile");
        }
    }
}
