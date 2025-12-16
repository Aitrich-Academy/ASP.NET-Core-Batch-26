using JobProvider_BlazorApp.Data.Models;

namespace JobProvider_BlazorApp.Interface
{
    public interface IJobProviderRepository
    {
        Task<JobProvider> GetByEmailAsync(string email);
        Task AddAsync(JobProvider jobProvider);
    }
}
