using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Interface
{
    internal interface IUserRepository
    {
        bool Register(User user);
        
    }
}
