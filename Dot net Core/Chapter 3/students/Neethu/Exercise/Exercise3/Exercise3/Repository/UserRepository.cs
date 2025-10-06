using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise3.Enums;
using Exercise3.Interface;
using Exercise3.Models;
using Exercise3.Exceptions;

namespace Exercise3.Repository
{
    public sealed class UserRepository:IUserRepository
    {
        private List<User> users=new List<User> { new User("Alice","Mathew","alice@gmail.com","12345",9282575610,Roles.JobProvider),new User("Neethu","K J","neethu@gmail.com","6789", 9282575610, Roles.JobProvider) };
        public bool Register(User user)
        {
            try
            {
                user.Id = users.Count;
                if(users.Find(e=>e.Email==user.Email) == null )
                {
                    users.Add(user);
                    return true;
                }
                throw new UserAlreadyExistException("User already exist with this email id" + user.Email);
            }
            catch(UserAlreadyExistException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public User Login(string email,string password)
        {
            return users.FirstOrDefault(e => e.Email == email && e.Password == password);
        }

    }
}
