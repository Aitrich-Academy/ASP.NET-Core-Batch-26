using Service_Repo_Model.Data;
using Service_Repo_Model.Models;

namespace Service_Repo_Model.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _db;
        public UserRepository(AppDbContext db)
        {
            _db = db;
        }
        public User GetEmail(string email) => _db.Users.FirstOrDefault(u => u.Email == email);

        public void Add(User user)=>_db.Users.Add(user);

        public void Save()=>_db.SaveChanges();

        public User GetById(int id) => _db.Users.FirstOrDefault(u => u.Id == id);

        public void Update(User user)
        {
            _db.Users.Update(user);
        }
       
    }
}
