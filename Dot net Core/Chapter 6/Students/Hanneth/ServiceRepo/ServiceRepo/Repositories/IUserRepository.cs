using ServiceRepo.Model;

namespace ServiceRepo.Repositories
{
    public interface IUserRepository
    {
        User GetByEmail(string email);
        User GetById(int  id);
        void add(User user);
        void update(User user);
        void save();
    }
}
