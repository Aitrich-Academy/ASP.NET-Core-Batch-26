using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Services
{
    public class JobService:IJobService
    {
        private readonly IJobRepository jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }
        public List<Job> GetJobsPosted(Guid cmpId)
        {
            return jobRepository.GetJobsPosted(cmpId);
        }
    }
}
