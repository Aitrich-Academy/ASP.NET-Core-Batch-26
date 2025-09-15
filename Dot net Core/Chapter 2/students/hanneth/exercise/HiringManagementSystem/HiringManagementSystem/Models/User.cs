using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static HiringManagementSystem.enums.ExperienceLevelandRoles;

namespace HiringManagementSystem.Models
{
    public class User
    {
        public int Id {  get; set; }
        public  string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string Email {  get; set; }
        public string Phone {  get; set; }
        public string Password {  get; set; }
        Roles role {  get; set; }
      
    }
}
