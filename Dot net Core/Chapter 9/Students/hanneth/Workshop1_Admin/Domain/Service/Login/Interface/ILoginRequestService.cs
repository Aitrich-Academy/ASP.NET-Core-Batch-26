using Domain.Service.Login.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login.Interface
{
    public interface ILoginRequestService
    {
        AdminLoginDto AdminLogin(string email, string password);
    }
}
