using AutoMapper;
using Domain.Models;
using Domain.Services.Admin.DTOs;
using Domain.Services.Login.DTOs;
using HiremenowAdmin.API.Admin.RequestObjects;

namespace HiremenowAdmin.Extensions
{
    public class AutoMapperProfiles:Profile
    {

        public AutoMapperProfiles() 
        {
           
            CreateMap<AuthUser, Domain.Models.JobSeeker>().ReverseMap();
            CreateMap<AuthUser, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.CompanyUser>().ReverseMap();
          
            CreateMap<JobPost, Domain.Services.Admin.DTOs.JobProviderDTO>().ReverseMap();


            
            CreateMap<Industry, IndustryRequest>().ReverseMap();
            CreateMap<JobCategory, CategoryRequest>().ReverseMap();
            CreateMap<Location, LocationRequest>().ReverseMap();
            CreateMap<Location, LocationDTO>().ReverseMap();
            CreateMap<JobProviderCompany, Domain.Services.Admin.DTOs.JobProviderDTO>().ReverseMap();


           
            CreateMap<JobPost, Domain.Services.Admin.DTOs.JobListDTO>().ReverseMap();
            CreateMap<AuthUser, AdminLoginDTO>();

           
            CreateMap<JobPost, Domain.Services.Admin.DTOs.JobProviderDTO>().ReverseMap();
            CreateMap<Domain.Models.JobSeeker, JobSeekerDTO>().ReverseMap();
            CreateMap<JobProviderCompany, Domain.Services.Admin.DTOs.JobProviderDTO>().ReverseMap();

          

            CreateMap<SkillRequest, Skill>();
            CreateMap<CompanyUser, CompanyUserDTO>().ReverseMap();
        }
    }
}
