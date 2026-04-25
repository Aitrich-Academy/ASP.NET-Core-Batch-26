using Domain.Models;
using Domain.Service.Login.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login
{
    public class LoginRequestRepository:ILoginRequestRepository
    {
        private readonly DbHireMeNowWebApiContext _context;
        public LoginRequestRepository(DbHireMeNowWebApiContext context) { _context = context; }
        public AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email);
            return user;
        }
        public AuthUser GetUserByEmailpassword(string email, string password)
        {
            var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
            return user;
        }
    }
}
