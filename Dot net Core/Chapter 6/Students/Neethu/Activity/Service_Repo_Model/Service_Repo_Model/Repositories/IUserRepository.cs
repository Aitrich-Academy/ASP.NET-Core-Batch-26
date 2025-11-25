using Service_Repo_Model.Models;

namespace Service_Repo_Model.Repositories
{
    public interface IUserRepository
    {
        User GetEmail(string email);
        void Add(User user);
        void Save();
        User GetById(int id);

        void Update(User user); 
    }
}
