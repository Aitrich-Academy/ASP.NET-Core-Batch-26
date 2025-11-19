using Add_Profile.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Add_Profile.Pages
{
    public class DashboardModel : PageModel
    {
        public string WelcomeMessage { get; set; }
        public string UserName { get; set; }
        [BindProperty]
        public bool IsLoggedIn { get; set; }


        public void OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
            WelcomeMessage = $"Welcome, {UserName}";
            IsLoggedIn = true ;
        }
    }
}
