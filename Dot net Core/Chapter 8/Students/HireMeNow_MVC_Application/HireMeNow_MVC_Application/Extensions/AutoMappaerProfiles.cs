using AutoMapper;
using HireMeNow_MVC_Application.Models.DTOs;
using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Extensions
{
    public class AutoMappaerProfiles:Profile
    {
        public AutoMappaerProfiles()
        {
            CreateMap<JobDTO,Job>().ReverseMap();
        }
    }
}
