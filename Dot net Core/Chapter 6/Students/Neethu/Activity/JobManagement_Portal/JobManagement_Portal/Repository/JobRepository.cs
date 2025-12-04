using JobManagement_Portal.Dto;
using JobManagement_Portal.Interface;
using JobManagement_Portal.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace JobManagement_Portal.Repository
{
    public class JobRepository:IJobRepository
    {

        private readonly ApplicationDbContext _db;

        public JobRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            var jobs = await _db.Jobs.ToListAsync();
            return jobs;
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            var job = await _db.Jobs.FindAsync(id);
            return job;
        }
        public async Task AddJobAsync(Job job)
        {
            _db.Jobs.Add(job);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateJobAsync(int id, Job job)
        {
            var existingJob = await _db.Jobs.FindAsync(id);
            if (existingJob == null) return; 

            _db.Entry(existingJob).State = EntityState.Detached; 

            
            var updatedJob = job;
            updatedJob.Id = id; 

            _db.Jobs.Attach(updatedJob); 
            _db.Entry(updatedJob).State = EntityState.Modified; 
            await _db.SaveChangesAsync();
        }

        public async Task DeleteJobAsync(int id)
        {
            var deljob = await _db.Jobs.FindAsync(id);
            if(deljob==null)
            {
                return;
            }
            else
            {
                _db.Jobs.Remove(deljob);
                await _db.SaveChangesAsync();
            }
        }
    }
}
