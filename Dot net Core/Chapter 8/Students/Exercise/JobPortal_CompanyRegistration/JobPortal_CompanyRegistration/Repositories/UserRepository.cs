using JobPortal_CompanyRegistration.Models;

namespace JobPortal_CompanyRegistration.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;
        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool RegisterMember(User user)
        {
            var companyExists = context.Companies.Any(c => c.CompanyId == user.CompanyId);
            if (!companyExists)
                return false;

            context.Users.Add(user);
            context.SaveChanges();
            return true;
        }
        public List<User> GetAllMembers(Guid CompanyId)
        {
            var users = context.Users.ToList();
            return users;
        }
        public bool DeleteMember( Guid memberId, string name, string designation)
        {
            var user= context.Users.FirstOrDefault(u=>u.UserID==memberId&&u.FirstName==name&&u.Designation==designation);
            if (user!=null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
