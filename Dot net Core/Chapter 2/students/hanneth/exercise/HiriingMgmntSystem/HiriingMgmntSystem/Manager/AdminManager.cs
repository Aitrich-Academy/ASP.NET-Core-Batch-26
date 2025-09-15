using HiriingMgmntSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiriingMgmntSystem.Manager
{
    internal class AdminManager
    {
        User[] user=new User[2];
        Job jobs = new Job();
      public void ViewNewRegistrations()
        {
            for (int i = 0; i < user.Length; i++)
            {
                Console.WriteLine($"New user name:{user[i].Email}");
            }

        }
      public void ListAvailableJobs()
        {
        }
    }
}
