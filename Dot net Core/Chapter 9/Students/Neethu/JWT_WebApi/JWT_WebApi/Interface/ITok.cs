using JWT_WebApi.Models;

namespace JWT_WebApi.Interface
{
    public interface ITok
    {
        public string? CreateToken(User user);
        string GetUserName();
    }
}
