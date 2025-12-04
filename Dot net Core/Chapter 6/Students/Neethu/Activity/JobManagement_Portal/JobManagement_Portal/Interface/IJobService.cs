using JobManagement_Portal.Dto;
using JobManagement_Portal.Models;

namespace JobManagement_Portal.Interface
{
    public interface IJobService
    {
        public Task<List<JobDto>> GetAllJobsAsync();
        public Task AddJobAsync(JobDto job);

        public Task<JobDto> GetJobByIdAsync(int id);

        public Task UpdateJobAsync(int id, JobDto jobDto);

        public Task DeleteJobAsync(int id);
    }
}
