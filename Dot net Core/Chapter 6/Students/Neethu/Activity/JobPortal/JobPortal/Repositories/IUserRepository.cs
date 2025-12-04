using JobPortal.Models;

namespace JobPortal.Repositories
{
    public interface IUserRepository
    {
        public User GetByEmail(string email);
        public void AddUser(User user);

        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);

        public bool ApplyJob(JobApplication application);

        public Task<List<JobApplication>> GetAllApplicationsAsync(int id);
    }
}
