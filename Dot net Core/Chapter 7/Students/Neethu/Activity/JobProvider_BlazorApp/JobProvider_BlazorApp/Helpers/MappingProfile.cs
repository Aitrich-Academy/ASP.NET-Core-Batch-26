using AutoMapper;
using JobProvider_BlazorApp.Data.Models;
using JobProvider_BlazorApp.Dto;

namespace JobProvider_BlazorApp.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<JobProvider,JobProviderDto>().ReverseMap();
            CreateMap<Job,JobDto>().ReverseMap();

        }
    }
}
