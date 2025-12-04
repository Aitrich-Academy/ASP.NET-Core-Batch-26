using JobManagement_Portal.Dto;
using JobManagement_Portal.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobManagement_Portal.Pages.Job
{
    public class IndexModel : PageModel
    {

        private readonly IJobService _service;

        public IndexModel(IJobService service)
        {
            _service = service;
        }
       
        public List<JobDto> JobPosts { get; set; }
        public async Task OnGetAsync()
        {
            JobPosts=await _service.GetAllJobsAsync();
        }
    }
}
