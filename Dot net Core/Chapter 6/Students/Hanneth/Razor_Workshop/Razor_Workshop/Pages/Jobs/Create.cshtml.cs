using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Workshop.dto;
using Razor_Workshop.Services;

namespace Razor_Workshop.Pages.Jobs
{
    public class CreateModel : PageModel
    {
        private readonly IJobServices _jobServices;
        [BindProperty]
        public Jobdto JobPost { get; set; }
        public CreateModel(IJobServices jobServices)
        {
            _jobServices = jobServices;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            await _jobServices.AddJobAsync(JobPost);
            return RedirectToPage("Index");
        }
    }
}
