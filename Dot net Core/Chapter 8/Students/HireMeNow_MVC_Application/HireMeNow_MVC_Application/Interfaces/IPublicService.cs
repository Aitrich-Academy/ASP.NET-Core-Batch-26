using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Interfaces
{
    public interface IPublicService
    {
        public User Register(User user);
        public User LoginJobProvider(string email,string password);
    }
}
