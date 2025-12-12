using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceRepo.Model;
using ServiceRepo.Services;

namespace ServiceRepo.Pages
{
    public class EditProfileModel : PageModel
    {
        private readonly IUserService _service;
        public EditProfileModel(IUserService service)
        {
            _service = service;
        }
        public User Input { get; set; }
        public void OnGet()
        {
            int userId = (int)HttpContext.Session.GetInt32("UserId");
            if (userId !=null) {Input=_service.GetUser(userId); }
        }
        public IActionResult OnPost()
        {
            var UserId= HttpContext.Session.GetInt32("UserId");
            if (UserId != null)
            {
                var dbUser = _service.GetUser(UserId.Value);
                if (dbUser != null)
                {
                    dbUser.FirstName = Input.FirstName;
                    dbUser.LastName = Input.LastName;
                    _service.UpdateUser(dbUser);
                }
            }
           return  RedirectToPage("/Profile");
        }
    }
}
