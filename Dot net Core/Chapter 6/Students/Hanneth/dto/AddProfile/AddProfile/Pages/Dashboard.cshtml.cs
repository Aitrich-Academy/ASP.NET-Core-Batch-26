using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddProfile.Pages
{
    public class DashboardModel : PageModel
    {
        public string UserName { get; set; }
        public void OnGet()
        {
            HttpContext.Session.GetString("UserName");
        }
    }
}
