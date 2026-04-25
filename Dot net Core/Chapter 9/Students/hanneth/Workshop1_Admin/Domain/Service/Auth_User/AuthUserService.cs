using Domain.Service.Auth_User.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Auth_User
{
    public class AuthUserService:IAuthUserService
    {
        private readonly IAuthUserRepository _authUserRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthUserService(IAuthUserRepository authUserRepository, IHttpContextAccessor httpContextAccessor)
        {
            _authUserRepository = authUserRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId()
        {
            var result = string.Empty;
            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value.ToString();
            }
            return result;
        }
    }
}
