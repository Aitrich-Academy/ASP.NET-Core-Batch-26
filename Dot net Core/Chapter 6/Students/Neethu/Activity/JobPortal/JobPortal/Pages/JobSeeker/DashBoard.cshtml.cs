using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPortal.Services;

namespace JobPortal.Pages.JobSeeker
{
    public class DashBoardModel : PageModel
    {
        private readonly IUserService service;

        public DashBoardModel(IUserService service)
        {
            this.service = service;
        }
        public string UserName { get; set; }
        public int USERID { get; set; }
        public void OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
            var userid = HttpContext.Session.GetInt32("UserId");
            USERID = userid.Value;
        }
    }
}
