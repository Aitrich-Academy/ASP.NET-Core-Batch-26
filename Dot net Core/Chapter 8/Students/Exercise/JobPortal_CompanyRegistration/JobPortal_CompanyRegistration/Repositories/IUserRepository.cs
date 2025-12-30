using JobPortal_CompanyRegistration.Dto_s;
using JobPortal_CompanyRegistration.Models;

namespace JobPortal_CompanyRegistration.Repositories
{
    public interface IUserRepository
    {
        public bool RegisterMember(User user);
        public List<User> GetAllMembers(Guid CompanyId);
        public bool DeleteMember( Guid memberId, string name, string designation);
    }
}
