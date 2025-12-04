using JobManagement_Portal.Dto;
using JobManagement_Portal.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobManagement_Portal.Pages.Job
{
    public class DeleteModel : PageModel
    {
        private readonly IJobService jobService;

        public DeleteModel(IJobService jobService)
        {
            this.jobService = jobService;
        }
        public JobDto JobPost { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var jobdto=await jobService.GetJobByIdAsync(id);
            if (jobdto == null)
            {
                return NotFound();
            }
            else
            {
                JobPost = jobdto;
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await jobService.DeleteJobAsync(id);
            return RedirectToPage("Index");
        }
    }
}
