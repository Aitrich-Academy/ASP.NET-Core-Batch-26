using JWT.Interface;
using JWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT.Controllers
{
    [Route("api/Values")]
    [ApiController]
    [Authorize(Roles = "JOB_SEEKER")]
    public class ValuesController : ControllerBase
    {

        private readonly Context _context;
        private readonly Itok tokrepo;
        public ValuesController(Itok _tokrepo, Context context)
        {
           
            _context = context;
            tokrepo = _tokrepo; 
        }

        [HttpGet]
    
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
     
        [HttpPost]
        [AllowAnonymous]
        public IActionResult register([FromBody] User user)
        {
            user.Id = Guid.NewGuid();
            user.role = Enums.Role.JOB_SEEKER;
            _context.Students.Add(user);
           _context.SaveChanges();  
            return Ok();

        }
        [HttpPost("/login")]
        [AllowAnonymous]
        public IActionResult login([FromBody] LoginRequest request)
        {
            var user = _context.Students.Where(e => e.Email == request.Email && e.Password == request.Password).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Invalid credentials");
            }
            else
            {
                string? Token = tokrepo.CreateToken(user);
                return Ok(Token);
            }
            

        }
      
        [HttpGet("GetUser")]

        public IActionResult getName()
        {
            return Ok(tokrepo.GetUserName()); 
        }








    }
}

