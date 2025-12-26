using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Interfaces
{
    public interface IJobService
    {
        public List<Job> GetJobsPosted(Guid cmpId);
    }
}
