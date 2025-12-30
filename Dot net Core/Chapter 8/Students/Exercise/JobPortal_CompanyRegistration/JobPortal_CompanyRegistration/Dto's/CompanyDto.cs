using JobPortal_CompanyRegistration.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal_CompanyRegistration.Dto_s
{
    public class CompanyDto
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
        public string Phone { get; set; }
        [Required]
        public string Website { get; set; }
        [Required]
        public string Vision { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public string Mission { get; set; }

       

    }
}
