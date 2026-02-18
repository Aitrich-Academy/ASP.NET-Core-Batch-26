using Domain.Dto_s;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class JobRepository:IJobRepository
    {
        private readonly AppDbContext context;
        public JobRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            return await context.Jobs.ToListAsync();
        }
        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await context.Jobs.FirstOrDefaultAsync(j=>j.Id == id);    
        }
        public async Task<Job> AddJobAsync(Job job)
        {
            context.Jobs.Add(job);
            await context.SaveChangesAsync();
            return job;
        }
        public async Task<Job> UpdateJobAsync(Job job)
        {
            context.Jobs.Update(job);
            await context.SaveChangesAsync();
            return job;
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            var job = await context.Jobs.FindAsync(id);
            if (job == null) return false;

            context.Jobs.Remove(job);
            await context.SaveChangesAsync();
            return true;
        }

    }
}
