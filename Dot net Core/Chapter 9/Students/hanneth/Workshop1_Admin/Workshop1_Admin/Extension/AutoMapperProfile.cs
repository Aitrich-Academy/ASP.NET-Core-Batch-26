using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.Dto;
using Domain.Service.Login.DTO;
using Domain.Service.Profile.Dto;
using Workshop1_Admin.API.Admin.RequestObjects;

namespace Workshop1_Admin.Extension
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            
            CreateMap<AuthUser, Domain.Models.JobSeeker>().ReverseMap();
            CreateMap<AuthUser, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.CompanyUser>().ReverseMap();  
            CreateMap<JobPost, Domain.Service.Admin.Dto.JobProviderDto>().ReverseMap();
            CreateMap<Skill, SkillDto>();
            CreateMap<JobCategory, CategoryRequest>().ReverseMap();
            CreateMap<Location, LocationRequest>().ReverseMap();
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<JobProviderCompany, Domain.Service.Admin.Dto.JobProviderDto>().ReverseMap();           
            CreateMap<JobPost, JobListDto>().ReverseMap();
            CreateMap<AuthUser, AdminLoginDto>();
            CreateMap<JobPost, Domain.Service.Admin.Dto.JobProviderDto>().ReverseMap();
            CreateMap<Domain.Models.JobSeeker, JobSeekerDto>().ReverseMap();
            CreateMap<JobProviderCompany, Domain.Service.Admin.Dto.JobProviderDto>().ReverseMap();
            CreateMap<SkillRequest, SkillDto>();
            CreateMap<SkillDto, Skill>();

        }
    }
}
