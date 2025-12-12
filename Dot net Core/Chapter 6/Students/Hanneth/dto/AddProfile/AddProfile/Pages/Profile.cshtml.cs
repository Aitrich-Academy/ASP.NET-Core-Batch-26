using AddProfile.Data;
using AddProfile.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddProfile.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public ProfileModel (ApplicationDbContext context)
        {
            _context = context;
        }
        public User User {  get; set; }
        public void OnGet()
        {
            var UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId!=null)
            {
               User= _context.users.FirstOrDefault(u=>u.id==UserId);
            }
        }
        public void OnPost()
        {
            RedirectToPage("/EditProfile");
        }
    }
}
