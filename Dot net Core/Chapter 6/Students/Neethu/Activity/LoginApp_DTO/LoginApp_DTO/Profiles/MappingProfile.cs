using AutoMapper;
using LoginApp_DTO.DTOs;
using LoginApp_DTO.Models;

namespace LoginApp_DTO.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterDto, User>();
        }
    }
}
