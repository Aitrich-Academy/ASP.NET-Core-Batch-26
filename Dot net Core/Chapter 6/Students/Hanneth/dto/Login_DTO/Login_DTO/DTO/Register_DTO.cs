using System.ComponentModel.DataAnnotations;

namespace Login_DTO.DTO
{
    public class Register_DTO
    {
        [Required]
        public string FirstName {  get; set; }
        [Required]
        public string LastName {  get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
