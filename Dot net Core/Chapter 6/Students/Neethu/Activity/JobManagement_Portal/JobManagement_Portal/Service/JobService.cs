using AutoMapper;
using JobManagement_Portal.Dto;
using JobManagement_Portal.Interface;
using JobManagement_Portal.Models;
using JobManagement_Portal.Repository;

namespace JobManagement_Portal.Service
{
    public class JobService:IJobService
    {

        private readonly IJobRepository _Repo;

        private readonly IMapper mapper;

        public JobService(IJobRepository repo,IMapper Mapper)
        {
            _Repo = repo;
            mapper = Mapper;
        }

        public async Task<List<JobDto>> GetAllJobsAsync()
        {
            var job=await _Repo.GetAllJobsAsync();
            return mapper.Map<List<JobDto>>(job);
        }

        public async Task AddJobAsync(JobDto job)
        {
            var jobs = mapper.Map<Job>(job);
            await _Repo.AddJobAsync(jobs);
        }
        public async Task<JobDto> GetJobByIdAsync(int id)
        {
            var job = await _Repo.GetJobByIdAsync(id);
            return mapper.Map<JobDto>(job);
        }
        public async Task UpdateJobAsync(int id, JobDto jobDto)
        {
            var job = mapper.Map<Job>(jobDto);
            await _Repo.UpdateJobAsync(id, job);
        }

        public async Task DeleteJobAsync(int id)
        {
            await _Repo.DeleteJobAsync(id);
        }
    }
}
