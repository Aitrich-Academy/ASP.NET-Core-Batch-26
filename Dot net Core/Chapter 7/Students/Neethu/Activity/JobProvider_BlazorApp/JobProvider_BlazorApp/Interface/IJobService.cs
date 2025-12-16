using JobProvider_BlazorApp.Dto;

namespace JobProvider_BlazorApp.Interface
{
    public interface IJobService
    {

        Task<List<JobDto>> GetJobsByProviderIdAsync(int providerId);
        Task<bool> AddJobAsync(JobDto jobDto,int providerid);
        Task<bool> UpdateJobAsync(JobDto jobDto);
        Task<bool> DeleteJobAsync(int jobid);
    }
}
