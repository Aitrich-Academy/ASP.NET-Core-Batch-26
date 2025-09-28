using Admin_job.Interface;
using Admin_job.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_job.Manager
{
    
        public class UserManager : IMenu
        {
            private User loggedUser;

            public UserManager(User loggedUser)
            {
                this.loggedUser = loggedUser;
            }
            public UserManager()
            {

            }
            public void DisplayMenu()
            {
                throw new NotImplementedException();
            }
        }
    }

