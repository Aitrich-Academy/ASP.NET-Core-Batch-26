using AutoMapper;
using Razor_Workshop.dto;
using Razor_Workshop.Model;
using Razor_Workshop.Repository;

namespace Razor_Workshop.Services
{
    public class JobServices:IJobServices
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;
        public JobServices(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<List<Jobdto>> GetAllJobsAsync()
        {
            var job = await _jobRepository.GetAllJobsAsync();
            return _mapper.Map<List<Jobdto>>(job);
        }

        public async Task<Jobdto> GetJobByIdAsync(int id)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);
            return _mapper.Map<Jobdto>(job);
        }

        public async Task AddJobAsync(Jobdto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            await _jobRepository.AddJobAsync(job);
        }

        public async Task UpdateJobAsync(int id, Jobdto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            await _jobRepository.UpdateJobAsync(id, job);
        }

        public async Task DeleteJobAsync(int id)
        {
            await _jobRepository.DeleteJobAsync(id);
        }
    }
}
