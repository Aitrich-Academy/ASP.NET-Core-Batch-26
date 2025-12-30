using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Interfaces
{
    public interface IUserRepository
    {
        User Register(User user);
        User Login(string email, string password);
        User GetById(Guid id);
    }
}
