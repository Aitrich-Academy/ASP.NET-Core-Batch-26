using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Workshop.Data;
using Razor_Workshop.dto;
using Razor_Workshop.Services;

namespace Razor_Workshop.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly IJobServices _services;
        public List<Jobdto> Jobposts {  get; set; }
        public IndexModel(IJobServices services)
        {
            _services = services;
        }
       
        public async Task OnGetAsync()
        {
            Jobposts=await _services.GetAllJobsAsync();
        }
    }
}
