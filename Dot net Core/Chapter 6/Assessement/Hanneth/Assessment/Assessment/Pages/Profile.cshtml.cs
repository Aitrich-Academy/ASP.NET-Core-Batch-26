using Assessment.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assessment.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly AppDbContext _context;
        public ProfileModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public UserModel User { get; set; }
        public void OnGet()
        {
          //  User.FirstName = HttpContext.Session.GetString("Usename");
            HttpContext.Session.GetString("Usename");
            HttpContext.Session.GetString("LastName");
           HttpContext.Session.GetString("Email");
        }
    }
}
