using Service_Repo_Model.Models;
using Service_Repo_Model.Repositories;
namespace Service_Repo_Model.Services
{
    public class UserService:IUserService
    {

        private readonly IUserRepository _Repo;
        public UserService(IUserRepository repo)
        {
            _Repo = repo;
        }

        public bool Register(User user)
        {
            var existing= _Repo.GetEmail(user.Email);
            if (existing!=null)
            {
                return false;
            }
            else
            {
                _Repo.Add(user);
                _Repo.Save();
                return true;
            }
        }
        public User Login(string email, string password)
        {
            var user = _Repo.GetEmail(email);
            return (user != null && user.Password == password) ? user:null ;
        }

        public User GetUser(int  id)
        {
            return _Repo.GetById(id);
        }

        public void UpdateUser(User user)
        {
            _Repo.Update(user);
            _Repo.Save();
        }

    }
}
