using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProvider.Exceptions
{
    internal class UserAlreadyExistsException:Exception
    {
        public UserAlreadyExistsException()
        { }
        public UserAlreadyExistsException(string email):base(string.Format("User already exists with this email",email))
        {

        }
        
    }
}
