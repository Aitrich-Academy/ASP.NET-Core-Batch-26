using JobProvider_BlazorApp.Data;
using JobProvider_BlazorApp.Data.Models;
using JobProvider_BlazorApp.Dto;
using JobProvider_BlazorApp.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobProvider_BlazorApp.Repositories
{
    public class JobRepository:IJobRepository
    {

        private readonly AppDbContext context;

        public JobRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Job>> GetJobsByProviderIdAsync(int providerId)
        {
            return await context.Jobs.Where(j => j.JobProviderId == providerId).ToListAsync();
        }
        public async Task AddAsync(Job job)
        {
            context.Jobs.Add(job);
            await context.SaveChangesAsync();
        }
        public async Task<Job> GetByIdAsync(int jobId)
        {
            return await context.Jobs.FindAsync(jobId);
        }
        public async Task UpdateAsync(Job job)
        {
             context.Update(job);
            await context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int jobId)
        {
            var jobs = await context.Jobs.FindAsync(jobId);
            if (jobs != null)
            {
                context.Jobs.Remove(jobs);
                await context.SaveChangesAsync();
            }
        }
    }
}
