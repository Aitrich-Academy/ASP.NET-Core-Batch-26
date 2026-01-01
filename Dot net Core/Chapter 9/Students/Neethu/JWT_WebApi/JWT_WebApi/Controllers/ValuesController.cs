using JWT_WebApi.Enums;
using JWT_WebApi.Interface;
using JWT_WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_WebApi.Controllers
{
    [Route("api/Values")]
    [ApiController]
    [Authorize(Roles ="JOB_SEEKER")]
    public class ValuesController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly ITok tokrepo;
        public ValuesController(AppDbContext context, ITok tokrepo)
        {
            this.context = context;
            this.tokrepo = tokrepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("HelloWorld");
        }
        [HttpPost("/Register")]
        [AllowAnonymous]
        public IActionResult Register(User user)
        {
            user.Id=Guid.NewGuid();
            user.role=Enums.Role.JOB_SEEKER;
            context.Users.Add(user);
            context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginRequest request)
        {
            var user=context.Users.Where(e=>e.Email==request.Email&&e.Password==request.Password).FirstOrDefault();
            if (user==null)
            {
                return BadRequest("Invalid Credentials");
            }
            else
            {
                string? Token=tokrepo.CreateToken(user);
                return Ok(Token);
            }
        }
        [HttpGet("GetUser")]
        public IActionResult GetName()
        {
            return Ok(tokrepo.GetUserName());
        }


    }
}
