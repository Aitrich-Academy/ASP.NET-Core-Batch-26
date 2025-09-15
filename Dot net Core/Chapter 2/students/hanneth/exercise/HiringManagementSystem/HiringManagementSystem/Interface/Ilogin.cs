using HiringManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementSystem.Interface
{
    internal interface Ilogin
    {
        void Register();
        bool AdminLogin(string email, string password);
        bool UserLogin(string email, string password);

    }
}
