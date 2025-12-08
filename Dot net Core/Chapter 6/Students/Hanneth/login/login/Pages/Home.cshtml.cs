using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace login.Pages
{
    public class HomeModel : PageModel
    {
        public string WelcomeMessage { get; set; }
        public bool isLoggedIn {  get; set; }
        public IActionResult OnGet()
        {
            var userName=HttpContext.Session.GetString("username");
            if (!string.IsNullOrEmpty(userName))
            {
                WelcomeMessage = $"welcome  {userName}!!";
                isLoggedIn=true;
            }
            else
            {
                WelcomeMessage = $"welcome !!! Please Login or Register!!!";
                isLoggedIn=false;
            }
            return Page();
        }
        public IActionResult OnPostLogout()
        {
            HttpContext.Session.Clear();
            return RedirectToPage("/Register");
            return RedirectToPage("/Login");
        }
    }
}
