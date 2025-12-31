using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal_CompanyRegistration.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email {  get; set; }
        [Required]
        public string Phone {  get; set; }
        [Required]
        public string Designation { get; set; }
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

        public virtual Company Company { get; set; }

        


    }
}
