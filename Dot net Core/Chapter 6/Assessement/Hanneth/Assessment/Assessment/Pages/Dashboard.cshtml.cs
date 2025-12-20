using Assessment.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assessment.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly AppDbContext _context;
        public DashboardModel(AppDbContext context)
        {
            _context = context;
        }
        public string user {  get; set; }
        public void OnGet()
        {
          user=  HttpContext.Session.GetString("Usename");
        }
        public void OnPost() {
            RedirectToPage("/Profile");
        }
    }
}
