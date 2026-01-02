using Domain.Models;
using Domain.Services.Login.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Login
{
    public class LoginRequestRepository:ILoginRequestRepository
    {
        protected readonly HireMeNowDbContext _context;
        public LoginRequestRepository(HireMeNowDbContext dbContext)
        {
            _context = dbContext;
        }

        public Domain.Models.AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email);

            return user;
        }


        public Domain.Models.AuthUser GetUserByEmailpassword(string email, string password)
        {
            var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
            
            return user;
        }
    }
}
