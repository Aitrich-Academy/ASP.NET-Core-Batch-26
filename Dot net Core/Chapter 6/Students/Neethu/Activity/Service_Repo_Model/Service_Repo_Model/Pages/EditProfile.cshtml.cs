using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Model.Models;
using Service_Repo_Model.Services;

namespace Service_Repo_Model.Pages
{
    public class EditProfileModel : PageModel
    {
        private readonly IUserService _Service;

        public EditProfileModel(IUserService service)
        {
             _Service = service;
        }

        [BindProperty]
        public User Input { get; set; }

        public void OnGet()
        {
            var userid = HttpContext.Session.GetInt32("UserId");
            if(userid!=null)
            {
                Input=_Service.GetUser(userid.Value);
            }
        }
        public IActionResult OnPost()
        {
            var userid = HttpContext.Session.GetInt32("UserId");
            if(userid!=null)
            {
                var dbuser=_Service.GetUser(userid.Value);
                if(dbuser!=null)
                {
                    dbuser.FirstName = Input.FirstName;
                    dbuser.LastName = Input.LastName;
                    _Service.UpdateUser(dbuser);
                }
            }
            return RedirectToPage("/Profile");
        }
    }
}
