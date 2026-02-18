using Domain.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IJobService
    {
        public Task<IEnumerable<JobDto>> GetAllJobsAsync();
        public Task<JobDto> GetJobByIdAsync(int id);
        public Task<JobDto> AddJobAsync(JobDto jobDto);
        Task<JobDto> UpdateJobAsync(JobDto jobDto);
        Task<bool> DeleteJobAsync(int id);
    }
}
