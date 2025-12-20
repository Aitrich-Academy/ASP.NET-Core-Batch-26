using JobProvider_BlazorApp.Data;
using JobProvider_BlazorApp.Data.Models;
using JobProvider_BlazorApp.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobProvider_BlazorApp.Repositories
{
    public class JobProviderRepository:IJobProviderRepository
    {

        private readonly AppDbContext context;

        public JobProviderRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task <JobProvider> GetByEmailAsync(string email)
        {
            return await context.JobProviders.FirstOrDefaultAsync(jp => jp.Email == email);
            
        }

        public async Task AddAsync(JobProvider provider)
        {
            context.JobProviders.Add(provider);
           await context.SaveChangesAsync();
        }
    }
}
