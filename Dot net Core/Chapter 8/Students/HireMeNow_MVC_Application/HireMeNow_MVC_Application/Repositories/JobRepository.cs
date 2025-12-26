using HireMeNow_MVC_Application.Data;
using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Repositories
{
    public class JobRepository:IJobRepository
    {

        private readonly AppDbContext context;
        public JobRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool Create(Job job)
        {
            context.Jobs.Add(job);
            context.SaveChanges();
            return true;
        }
        public List<Job> GetJobsPosted(Guid cmpId)
        {
            return context.Jobs.Where(j=>j.CompanyId== cmpId).ToList();
        }
    }
}
