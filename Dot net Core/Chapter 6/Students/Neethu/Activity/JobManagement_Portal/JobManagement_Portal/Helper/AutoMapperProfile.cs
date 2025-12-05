using AutoMapper;
using JobManagement_Portal.Dto;
using JobManagement_Portal.Models;

namespace JobManagement_Portal.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job,JobDto>().ReverseMap();
        }
    }
}
