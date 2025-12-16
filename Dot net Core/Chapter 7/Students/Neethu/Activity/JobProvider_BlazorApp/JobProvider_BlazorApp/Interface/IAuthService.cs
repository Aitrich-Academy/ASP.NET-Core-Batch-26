using JobProvider_BlazorApp.Dto;

namespace JobProvider_BlazorApp.Interface
{
    public interface IAuthService
    {

        public Task<bool> Register(JobProviderDto jobProvider, string password);

        Task<bool> Login(string email, string password);
    }
}
