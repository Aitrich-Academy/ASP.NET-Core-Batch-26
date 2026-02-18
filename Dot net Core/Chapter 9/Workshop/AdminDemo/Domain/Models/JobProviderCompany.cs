using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class JobProviderCompany
    {
        [Key]
        
      
        public Guid JobProviderCompanyId { get; set; } = Guid.NewGuid();

        public string? LegalName { get; set; } 

        public string? Summary { get; set; }
        public string? Email { get; set; }

        public long Phone { get; set; }

        public string? Address { get; set; } 

        public string? Website { get; set; }

        [ForeignKey(nameof(Industry))]
        public Guid IndustryId { get; set; }
        public virtual Industry? Industry { get; set; }



        [ForeignKey(nameof(LocationNavigation))]
        public Guid Location { get; set; }
        public virtual Location LocationNavigation { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();

        public virtual ICollection<CompanyUser> CompanyUsers { get; set; } = new List<CompanyUser>();

        
    }
}
