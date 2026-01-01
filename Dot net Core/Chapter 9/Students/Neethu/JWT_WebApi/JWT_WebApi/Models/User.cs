using JWT_WebApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace JWT_WebApi.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        
        public string? Name { get; set; }
     
        public string? Email { get; set; }
       
        public string? Password { get; set; }
        
        public Role role { get; set; }
    }
}
