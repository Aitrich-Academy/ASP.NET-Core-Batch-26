using Add_Profile.Data;
using Add_Profile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace Add_Profile.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public ProfileModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public User user { get; set; }

       public void OnGet()
        {
            var userid = HttpContext.Session.GetInt32("UserId");
            if(userid!=null)
            {
                user = _db.Users.FirstOrDefault(u => u.Id == userid);

            }
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/EditProfile");
        }
    }
}
