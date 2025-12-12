using System.ComponentModel.DataAnnotations;

namespace ServiceRepo.Model
{
    public class User
    {
        [Key]
        public int id {  get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
