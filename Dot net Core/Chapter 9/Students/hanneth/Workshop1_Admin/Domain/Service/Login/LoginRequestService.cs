using AutoMapper;
using Domain.Service.Auth_User.Interface;
using Domain.Service.Auth_User;
using Domain.Service.Auth_User.Interface;
using Domain.Service.Login.DTO;
using Domain.Service.Login.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login
{
    public class LoginRequestService:ILoginRequestService
    {
        private readonly ILoginRequestRepository _loginRequestRepository;
        private readonly IMapper _mapper;
        IAuthUserRepository _authUserRepository;
        public LoginRequestService(ILoginRequestRepository loginRequestRepository, IMapper mapper,IAuthUserRepository authUserRepository)
        {
            _loginRequestRepository = loginRequestRepository;
            _mapper = mapper;
            _authUserRepository = authUserRepository;
        }
        public AdminLoginDto AdminLogin(string email, string password)
        {
            var user = _loginRequestRepository.GetUserByEmail(email);
            if (user == null)
            {
                return null;
            }
            else
            {
                if ((password == user.Password))
                {
                    var userReturn = _mapper.Map<AdminLoginDto>(user);
                    userReturn.Token = _authUserRepository.CreateToken(user);
                    return userReturn;
                }
                return null;
            }

        }
    }
}
