using ServiceRepo.Model;

namespace ServiceRepo.Services
{
    public interface IUserService
    {
        bool Register(User user);
        User Login(string email,string password);
        User GetUser(int id);
        void UpdateUser(User user);
    }
}
