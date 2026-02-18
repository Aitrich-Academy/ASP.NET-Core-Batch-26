using AutoMapper;
using Domain.Dto_s;
using Domain.Interfaces;
using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class JobService:IJobService
    {
        private readonly IJobRepository jobRepository;
        private readonly IMapper mapper;
        public JobService(IJobRepository jobRepository,IMapper mapper)
        {
            this.jobRepository = jobRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<JobDto>> GetAllJobsAsync()
        {
            var jobs=await jobRepository.GetAllJobsAsync();
            return mapper.Map<IEnumerable<JobDto>>(jobs);
        }
        public async Task<JobDto> GetJobByIdAsync(int id)
        {
            var job=await jobRepository.GetJobByIdAsync(id);
            return mapper.Map<JobDto>(job);
        }
        public async Task<JobDto> AddJobAsync(JobDto jobDto)
        {
            var job = mapper.Map<Job>(jobDto);
            job=await jobRepository.AddJobAsync(job);
            return mapper.Map<JobDto>(job);

        }
        public async Task<JobDto> UpdateJobAsync(JobDto jobDto)
        {
            var job = mapper.Map<Job>(jobDto);
            job = await jobRepository.UpdateJobAsync(job);
            return mapper.Map<JobDto>(job);
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            return await jobRepository.DeleteJobAsync(id);
        }
    }
}
