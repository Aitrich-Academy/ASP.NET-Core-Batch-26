using JobPortal_CompanyRegistration.Dto_s;

namespace JobPortal_CompanyRegistration.Services
{
    public interface IUserService
    {
        public bool RegisterMember(UserDto userDto);
        public List<UserDto> GetAllMembers(Guid CompanyId);
        public bool DeleteMember( Guid memberId, string name, string designation);
    }
}
