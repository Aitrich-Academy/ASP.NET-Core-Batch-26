using AutoMapper;
using JobPortal_CompanyRegistration.Dto_s;
using JobPortal_CompanyRegistration.Models;

namespace JobPortal_CompanyRegistration.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CompanyDto,Company>().ReverseMap();
            CreateMap<UserDto,User>().ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.CompanyId)).ReverseMap();

        }
    }
}
