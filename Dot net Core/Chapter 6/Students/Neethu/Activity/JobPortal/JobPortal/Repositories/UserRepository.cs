using JobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext context;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public User GetByEmail(string email) => context.Users.FirstOrDefault(u => u.Email == email);

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        
        public Task<List<Job>> GetAllJobsAsync()
        {
            return context.Jobs.ToListAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return  context.Jobs.FirstOrDefault(u => u.JobId == id);
        }
        public bool ApplyJob(JobApplication application)
        {
            bool alreadyApplied = context.Applications
        .Any(a => a.JobID == application.JobID && a.UserId==application.UserId);
            if(alreadyApplied)
            {
                return false;
            }

            context.Applications.Add(application);
            context.SaveChanges();
            return true;
        }

        public async Task<List<JobApplication>> GetAllApplicationsAsync(int id)
        {
            return await context.Applications.Where(j=>j.UserId==id).ToListAsync();
        }


    }
}
