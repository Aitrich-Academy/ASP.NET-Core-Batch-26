using Microsoft.EntityFrameworkCore;
using Razor_Workshop.Data;
using Razor_Workshop.Model;

namespace Razor_Workshop.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly ApplicationDbContext _context;


        public JobRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            var job = await _context.jobs.ToListAsync();
            return job;
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            var job = await _context.jobs.FindAsync(id);
            return job;
        }

        public async Task AddJobAsync(Job job)
        {
            _context.jobs.Add(job);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateJobAsync(int id, Job job)
        {
            var existingJob = await _context.jobs.FindAsync(id);
            if (existingJob == null) return; 

            _context.Entry(existingJob).State = EntityState.Detached;

          
            var updatedJob = job;
            updatedJob.Id = id;

            _context.jobs.Attach(updatedJob);
            _context.Entry(updatedJob).State = EntityState.Modified; 

            await _context.SaveChangesAsync();
        }

        public async Task DeleteJobAsync(int id)
        {
            var job = await _context.jobs.FindAsync(id);
            if (job != null)
            {
                _context.jobs.Remove(job);
                await _context.SaveChangesAsync();
            }
        }
    }
}

