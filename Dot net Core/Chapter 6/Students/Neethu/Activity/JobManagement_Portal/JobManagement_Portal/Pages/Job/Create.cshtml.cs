using JobManagement_Portal.Dto;
using JobManagement_Portal.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobManagement_Portal.Pages.Job
{
    public class CreateModel : PageModel
    {
        private readonly IJobService jobService;
        public CreateModel(IJobService jobService)
        {
            this.jobService = jobService;
        }

        [BindProperty]
        public JobDto JobPost { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                await jobService.AddJobAsync(JobPost);
                return RedirectToPage("Index");
            }
        }


    }
}
