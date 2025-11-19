using Add_Profile.Data;
using Add_Profile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace Add_Profile.Pages
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
            var userid = HttpContext.Session.GetInt32("UserId");
            if(userid!=null)
            {
                Input = _context.Users.FirstOrDefault(u => u.Id == userid);

            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var userid = HttpContext.Session.GetInt32("UserId");
            if (userid != null)
            {
                var dbuser = _context.Users.FirstOrDefault(u => u.Id == userid);
                if (dbuser != null)
                {
                    dbuser.FirstName=Input.FirstName;
                    dbuser.LastName=Input.LastName;
                   await  _context.SaveChangesAsync();
                }

            }
            return RedirectToPage("/Profile");
        }
        
    }
}
