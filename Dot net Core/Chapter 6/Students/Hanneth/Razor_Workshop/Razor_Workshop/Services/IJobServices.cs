using Razor_Workshop.dto;

namespace Razor_Workshop.Services
{
    public interface IJobServices
    {
        public Task<List<Jobdto>> GetAllJobsAsync();

        public Task<Jobdto> GetJobByIdAsync(int id);


        public Task AddJobAsync(Jobdto jobDto);


        public Task UpdateJobAsync(int id, Jobdto jobDto);

        public Task DeleteJobAsync(int id);
    }
}
