using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Workshop.dto;
using Razor_Workshop.Services;

namespace Razor_Workshop.Pages.Jobs
{
    public class EditModel : PageModel
    {
        private readonly IJobServices _jobServices;
        [BindProperty]
        public Jobdto JobPost { get; set; }
        public EditModel(IJobServices jobServices)
        {
            _jobServices = jobServices;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var jobdto=await _jobServices.GetJobByIdAsync(id);
            if (jobdto == null)
            {
                return NotFound();
            }
            JobPost = jobdto;
            return Page();  
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _jobServices.UpdateJobAsync(JobPost.Id, JobPost);
            return RedirectToPage("Index");
        }
    }
}
