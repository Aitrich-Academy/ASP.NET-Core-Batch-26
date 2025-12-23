using AutoMapper;
using Login_MVC.Models;
namespace Login_MVC.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto,User>().ReverseMap();
        }
    }
}
