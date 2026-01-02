using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services.AuthUser.Interfaces
{
    public interface IAuthUserRepository
    {
      public  string? CreateToken(Domain.Models.AuthUser user);
    }
}
