using JobPortal.Models;
using JobPortal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;

namespace JobPortal.Pages.JobSeeker
{
    public class JobListingsModel : PageModel
    {

        private readonly IUserService service;

        public JobListingsModel(IUserService service)
        {
            this.service = service;
        }
        public List<Job> JobPosts { get; set; }= new List<Job>();

        public Job job { get; set; }

        public JobApplication application { get; set; }

        public bool success {  get; set; }
        public string Message { get; set; }
        public int UserID { get; set; }
        public async Task  OnGetAsync()
        {
            JobPosts = await service.GetAllJobsAsync();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            
            job= await service.GetJobByIdAsync(id);
            var uid= HttpContext.Session.GetInt32("UserId");
            UserID=uid.Value;

            if(job == null)
            {
                return NotFound();
            }
            application = new JobApplication
            {
                JobID = job.JobId,
                UserId=UserID,
                JobTitle = job.JobTitle,
                Company = job.Company,
                Location = job.Location,
                JobType = job.JobType,
                Salary = job.Salary,
                
                
            };

            success = service.ApplyJob(application);
            if(success) 
            return Page();
            else
            {
                Message = "Duplicates not allowed";
                return Page();
            }

           
        }
    }
}
