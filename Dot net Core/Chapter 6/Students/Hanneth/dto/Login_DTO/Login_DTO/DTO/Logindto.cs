using System.ComponentModel.DataAnnotations;

namespace Login_DTO.DTO
{
    public class Logindto
    {

        [Required,EmailAddress]
        public string Email {  get; set; }
        [Required]
        public string Password {  get; set; }

    }
}
