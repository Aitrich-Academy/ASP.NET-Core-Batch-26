using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Auth_User.Interface
{
    public interface IAuthUserRepository
    {
        string? CreateToken(AuthUser user);
    }
}
