using JobManagement_Portal.Dto;
using JobManagement_Portal.Models;

namespace JobManagement_Portal.Interface
{
    public interface IJobRepository
    {

        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);
        public Task AddJobAsync(Job job);

        public Task UpdateJobAsync(int id, Job job);

        public Task DeleteJobAsync(int id);
        
    }
}
