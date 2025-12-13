using Razor_Workshop.Model;

namespace Razor_Workshop.Repository
{
    public interface IJobRepository
    {
        public Task<List<Job>> GetAllJobsAsync();
        public Task<Job> GetJobByIdAsync(int id);
        public Task AddJobAsync(Job job);
        public Task DeleteJobAsync(int id);
        public Task UpdateJobAsync(int id,Job job);
    }
}
