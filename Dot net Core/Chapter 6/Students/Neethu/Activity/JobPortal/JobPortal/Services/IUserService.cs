using JobPortal.Models;
using Microsoft.Identity.Client;

namespace JobPortal.Services
{
    public interface IUserService
    {
        public bool RegisterUser(User user);

        public User Login(string email, string password);

        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);

        public bool ApplyJob(JobApplication application);

        public Task<List<JobApplication>> GetAllApplicationsAsync(int id);
    }
}
