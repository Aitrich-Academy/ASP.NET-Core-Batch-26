using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Model.Models;
using Service_Repo_Model.Services;

namespace Service_Repo_Model.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly IUserService _Service;

        public ProfileModel(IUserService service)
        {
            _Service = service;
        }

        public User user { get; set; }
        public void OnGet()
        {
            var userid = HttpContext.Session.GetInt32("UserId");
            if(userid!=null)
            {
                user = _Service.GetUser(userid.Value);
            }
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/EditProfile");
        }
    }
}
