using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceRepo.Model;
using ServiceRepo.Services;

namespace ServiceRepo.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly IUserService _service;
        public ProfileModel(IUserService service)
        {
            _service = service;
        }
        public User user { get; set; }
        public void OnGet()
        {
            var UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId != null) user = _service.GetUser(UserId.Value);
        }
        public IActionResult OnPost() => RedirectToPage("/EditProfile");
    }
}
