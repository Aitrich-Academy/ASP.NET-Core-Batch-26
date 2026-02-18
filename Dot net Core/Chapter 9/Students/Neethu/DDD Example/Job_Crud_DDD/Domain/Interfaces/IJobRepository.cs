using Domain.Dto_s;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IJobRepository
    {
        public Task<IEnumerable<Job>> GetAllJobsAsync();
        public Task<Job> GetJobByIdAsync(int id);
        public Task<Job> AddJobAsync(Job job);
        Task<Job> UpdateJobAsync(Job job);
        Task<bool> DeleteJobAsync(int id);
    }
}
