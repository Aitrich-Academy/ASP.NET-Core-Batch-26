using LoginApp_DTO.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginApp_DTO.Pages
{
    public class HomeModel : PageModel
    {

        public string WelcomeMessage { get; set; }

        public bool IsLoggedIn { get; set; }
        public IActionResult OnGet()
        {
            var username = HttpContext.Session.GetString("UserName");
            if(username!=null)
            {
                WelcomeMessage = $"Welcome{username} !";
                IsLoggedIn = true;
            }
            else
            {
                WelcomeMessage = "Welcome! Please login or register.";
                IsLoggedIn = false;
            }
            return Page();
        } 
        public IActionResult OnPostLogout()
        {
            HttpContext.Session.Clear();
            return RedirectToPage("/Login");
        }
    }
}
