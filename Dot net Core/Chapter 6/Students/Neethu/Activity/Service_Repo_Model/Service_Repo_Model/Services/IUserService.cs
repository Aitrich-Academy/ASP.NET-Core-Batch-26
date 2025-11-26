using Service_Repo_Model.Models;
namespace Service_Repo_Model.Services
{
    public interface IUserService
    {

        bool Register(User user);
        User Login(string Email, string password);

        User GetUser(int  id);
        void UpdateUser(User user); 
    }
}
