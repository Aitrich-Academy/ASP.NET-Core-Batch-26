using AutoMapper;
using JobProvider_BlazorApp.Data.Models;
using JobProvider_BlazorApp.Dto;
using JobProvider_BlazorApp.Interface;

namespace JobProvider_BlazorApp.Services
{
    public class JobService:IJobService
    {
        private readonly IJobRepository _Repo;
        private readonly IMapper _Mapper;
        
        public JobService(IJobRepository repo, IMapper mapper)
        {
            _Repo = repo;
            _Mapper = mapper;
        }

        public async Task<List<JobDto>> GetJobsByProviderIdAsync(int providerId)
        {
            var jobs=await _Repo.GetJobsByProviderIdAsync(providerId);
            return _Mapper.Map<List<JobDto>>(jobs);
        }
        public async Task<bool> AddJobAsync(JobDto jobDto, int providerId)
        {
            var job=_Mapper.Map<Job>(jobDto);
            job.JobProviderId = providerId;
            await _Repo.AddAsync(job);
            return true;
        }
        public async Task<bool> UpdateJobAsync(JobDto jobDto)
        {
            var job = await _Repo.GetByIdAsync(jobDto.Id);
            if(job == null) return false;
            _Mapper.Map(jobDto, job);
            await _Repo.UpdateAsync(job);
            return true;
            
        }
        public async Task<bool> DeleteJobAsync(int jobId)
        {
            await _Repo.DeleteAsync(jobId);
            return true;
        }
    }
}
