using AutoMapper;
using Login_DTO.DTO;
using Login_DTO.Model;

namespace Login_DTO.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Register_DTO, User>();
        }
    }
}
