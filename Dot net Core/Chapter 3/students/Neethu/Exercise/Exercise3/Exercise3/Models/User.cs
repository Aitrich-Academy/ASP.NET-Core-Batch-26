using Exercise3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long Phone {  get; set; }
        public Roles Role {  get; set; }
        public User() { }

        public User(string firstname,string lastname,string email, string password,long phone,Roles roles) 
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Password = password;
            Phone = phone;
            Role = roles;
        }
    }
}
