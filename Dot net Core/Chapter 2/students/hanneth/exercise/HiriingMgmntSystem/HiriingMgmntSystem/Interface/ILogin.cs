using HiriingMgmntSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiriingMgmntSystem.Interface
{
    internal interface ILogin
    {
        public bool Login(String username, String password);
        public void Register(User user);
    }
}
