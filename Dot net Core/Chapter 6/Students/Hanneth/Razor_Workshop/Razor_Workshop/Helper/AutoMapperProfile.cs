using AutoMapper;
using Razor_Workshop.dto;
using Razor_Workshop.Model;

namespace Razor_Workshop.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, Jobdto>().ReverseMap();
        }
    }
}
