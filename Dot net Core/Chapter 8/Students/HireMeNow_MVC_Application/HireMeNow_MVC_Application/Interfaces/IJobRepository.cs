using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Interfaces
{
    public interface IJobRepository
    {
        bool Create(Job job);
        public List<Job> GetJobsPosted(Guid cmpId);
    }
}
