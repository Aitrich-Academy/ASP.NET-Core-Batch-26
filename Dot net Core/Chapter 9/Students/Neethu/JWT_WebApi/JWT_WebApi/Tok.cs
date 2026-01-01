using JWT_WebApi.Interface;
using JWT_WebApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace JWT_WebApi
{
    public class Tok:ITok
    {
        private IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public Tok(IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _httpContextAccessor = httpContextAccessor;
        }
        public string? CreateToken(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User Object Cannot be null");
            }
            string tokenSecret = _config.GetSection("JWT:SecretKey").Value;
            if(string.IsNullOrEmpty(tokenSecret) )
            {
                throw new InvalidOperationException("Token secret is missing or empty in configuration.");
            }
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role,user.role.ToString())
            };
            var key=new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_config.GetSection("JWT:SecretKey").Value));
            var creds=new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);
            var jwt=new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
                

        }
        public string GetUserName()
        {
            string name=string.Empty;
            if(_httpContextAccessor.HttpContext != null)
            {
                name = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return name;
        }
    }
}
