using ServiceRepo.Data;
using ServiceRepo.Model;

namespace ServiceRepo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _db;
        public UserRepository(AppDBContext db)
        {
            _db = db;
        }
       public User GetByEmail(string email)=> _db.users.FirstOrDefault(u=>u.Email==email);
       public User GetById(int id) => _db.users.FirstOrDefault(u => u.id == id);
       public void add(User user) =>_db.users.Add(user);
       public void update(User user) =>_db.users.Update(user);
       public void save()=>_db.SaveChanges();

    }
}
