using AutoMapper;
using JobProvider_BlazorApp.Data.Models;
using JobProvider_BlazorApp.Dto;
using JobProvider_BlazorApp.Interface;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace JobProvider_BlazorApp.Services
{
    public class AuthService:IAuthService
    {
        private readonly IJobProviderRepository _jobProviderRepository;
        private readonly IMapper mapper;
        private readonly ProtectedSessionStorage sessionstorage;

        public AuthService(IJobProviderRepository jobProviderRepository, IMapper mapper,ProtectedSessionStorage browserStorage)
        {
            _jobProviderRepository = jobProviderRepository;
            this.mapper=mapper;
            sessionstorage=browserStorage;

        }
        public async Task<bool> Register(JobProviderDto jobProvider, string password)
        {
            var existing= await _jobProviderRepository.GetByEmailAsync(jobProvider.Email);
            if (existing != null)
                return false;
            var provider=mapper.Map<JobProvider>(jobProvider);
            provider.PasswordHash=BCrypt.Net.BCrypt.HashPassword(password); 

            await _jobProviderRepository.AddAsync(provider);
            return true;

        }

       public async Task<bool> Login(string email, string password)
        {
            var jobprovider=await _jobProviderRepository.GetByEmailAsync(email);
            if(jobprovider==null||!BCrypt.Net.BCrypt.Verify(password, jobprovider.PasswordHash)) 
                return false;
            try
            {
                await sessionstorage.SetAsync("JobProviderId", jobprovider.Id);
                await sessionstorage.SetAsync("JobProviderEmail", jobprovider.Email);
                Console.WriteLine("Session stored Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Session Error: ", ex.Message);
            }
            return true;
        }
    }
}
