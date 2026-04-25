using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login.Interface
{
    public interface ILoginRequestRepository
    {
        AuthUser GetUserByEmail(string email);
    }
}
