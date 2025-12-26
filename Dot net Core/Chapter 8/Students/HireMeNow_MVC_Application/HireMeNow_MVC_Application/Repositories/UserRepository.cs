using HireMeNow_MVC_Application.Data;
using HireMeNow_MVC_Application.Enums;
using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext context;
        private static User loggeduser = new User();
        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public User Register(User user)
        {
            user.Role = Roles.JobProvider;
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }
        public User Login(string email, string password)
        {
            loggeduser = context.Users.Where(u => u.Email == email && u.password == password).FirstOrDefault();
            return loggeduser;
        }
        public User GetById(Guid userid)
        {
            var user = context.Users.FirstOrDefault(u=>u.UseId == userid);
            return user;
        }
    }
}
