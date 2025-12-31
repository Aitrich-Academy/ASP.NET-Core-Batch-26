using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal_CompanyRegistration.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone {  get; set; }
        [Required]
        public string Website { get; set; }
        [Required]
        public string Vision { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public string Mission { get; set; }

        public virtual ICollection<User> Users { get; set; } =new List<User>();
        

    }
}
