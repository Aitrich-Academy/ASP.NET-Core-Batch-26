using JobPortal.Models;
using JobPortal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortal.Pages.JobSeeker
{
    public class AppliedJobscshtmlModel : PageModel
    {
        private readonly IUserService service;

        public AppliedJobscshtmlModel(IUserService service)
        {
            this.service = service;
        }
        public List<JobApplication> Application { get; set; }
        public async Task OnGetAsync(int id)
        {
            Application=await service.GetAllApplicationsAsync(id);

        }
    }
}
