using JobManagement_Portal.Dto;
using JobManagement_Portal.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobManagement_Portal.Pages.Job
{
    public class EditModel : PageModel
    {
        private readonly IJobService _service;

        [BindProperty]
        public JobDto JobPost { get; set; }

        public EditModel(IJobService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var jobDto = await _service.GetJobByIdAsync(id);
            if (jobDto == null)
            {
                return NotFound();
            }

            JobPost = jobDto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _service.UpdateJobAsync(JobPost.Id, JobPost);
            return RedirectToPage("Index");
        }
    }
}
