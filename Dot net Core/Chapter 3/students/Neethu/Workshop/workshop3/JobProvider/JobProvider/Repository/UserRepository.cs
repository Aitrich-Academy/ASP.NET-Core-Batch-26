using JobProvider.Enums;
using JobProvider.Exceptions;
using JobProvider.Interface;
using JobProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProvider.Repository
{
    public sealed class UserRepository:IUserRepository
    {
        private List<User> users=new List<User>();
        private int nextid = 2;

        public bool register(User user)
        {

            try
            {
                user.Id = nextid;
                user.Role = Roles.JobProvider;
                nextid++;
                if (users.Find(e => e.Email == user.Email) == null)
                {
                    users.Add(user);
                    return true;
                }
                else
                    throw new UserAlreadyExistsException(user.Email);
            }
            catch(UserAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public User login(string email,string password)
        {
            return users.FirstOrDefault(e=>e.Email==email && e.Password==password);
        }
    }
}
