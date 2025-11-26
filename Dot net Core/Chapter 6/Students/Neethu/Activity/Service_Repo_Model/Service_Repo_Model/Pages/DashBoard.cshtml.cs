using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service_Repo_Model.Services;

namespace Service_Repo_Model.Pages
{
    public class DashBoardModel : PageModel
    {
        public string UserName { get; set; }
        public void OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
        }
    }
}
