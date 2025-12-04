using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobManagement_Portal.Models;
using JobManagement_Portal.Dto;
using JobManagement_Portal.Interface;

namespace JobManagement_Portal.Pages.Job
{
    public class DetailsModel : PageModel
    {
        private readonly IJobService jobService;

        public DetailsModel(IJobService jobService)
        {
            this.jobService = jobService;
        }


        public JobDto JobPost { get; set; }
        public async Task<IActionResult>  OnGetAsync(int id)
        {
            JobPost= await jobService.GetJobByIdAsync(id);
            if(JobPost == null)
            {
                return NotFound();
            }
            return Page();

        }


    }
}
