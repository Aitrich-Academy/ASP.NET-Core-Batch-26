using AutoMapper;
using JobPortal_CompanyRegistration.Dto_s;
using JobPortal_CompanyRegistration.Models;
using JobPortal_CompanyRegistration.Repositories;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace JobPortal_CompanyRegistration.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public bool RegisterMember(UserDto userDto)
        {
            var user=mapper.Map<User>(userDto);
            return userRepository.RegisterMember(user);
        }
        public List<UserDto> GetAllMembers(Guid CompanyId)
        {
            var Memberlist=userRepository.GetAllMembers(CompanyId);
            return mapper.Map<List<UserDto>>(Memberlist);
            
        }
        public bool DeleteMember( Guid memberId, string name, string designation)
        {
            return userRepository.DeleteMember(memberId, name, designation);
        }
    }
}
