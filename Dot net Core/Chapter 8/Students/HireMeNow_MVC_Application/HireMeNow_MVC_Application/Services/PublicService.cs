using HireMeNow_MVC_Application.Exceptions;
using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models.Entities;

namespace HireMeNow_MVC_Application.Services
{
    public class PublicService:IPublicService
    {
        private readonly IUserRepository _userRepository;
        public PublicService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User LoggedUser =new User();
        bool _IsLoggedIn = false;

        public User Register(User user)
        {
            return _userRepository.Register(user);  
        }
        public User LoginJobProvider(string email,string password)
        {
            try
            {
                LoggedUser = _userRepository.Login(email, password);
                if(LoggedUser!=null)
                {
                    Console.WriteLine("Login Successfull");
                    _IsLoggedIn = true;
                    Console.WriteLine("Welcome" + LoggedUser.FirstName);
                    return LoggedUser;
                }
                else
                {
                    Console.WriteLine("Login failed. Please try again");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ServiceException("Technical Error Occured");
            }
        }
    }
}
