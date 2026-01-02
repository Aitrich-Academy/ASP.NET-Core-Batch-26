using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class CompanyUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanyUserId { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }

        [Required]
        public Enums.Role Role { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; } 
        public string? Phone { get; set; } 
       
        [ForeignKey(nameof(CompanyNavigation))]

        public Guid? Company { get; set; }
        [JsonIgnore]
        public virtual JobProviderCompany? CompanyNavigation { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
    }
}
