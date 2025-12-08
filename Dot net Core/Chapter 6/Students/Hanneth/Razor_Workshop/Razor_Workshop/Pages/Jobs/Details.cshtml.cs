using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Workshop.dto;
using Razor_Workshop.Services;

namespace Razor_Workshop.Pages.Jobs
{
    public class DetailsModel : PageModel
    {
        private readonly IJobServices _jobServices;
        public DetailsModel(IJobServices jobServices)
        {
            _jobServices = jobServices;
        }
        [BindProperty]
        public Jobdto JobPost {  get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            JobPost = await _jobServices.GetJobByIdAsync(id);
            if (JobPost == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
