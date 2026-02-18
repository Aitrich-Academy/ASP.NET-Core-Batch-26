using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LocationId { get; set; }

        public string? Name { get; set; } 

        public string? Description { get; set; } 

        public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();

        public virtual ICollection<JobProviderCompany> JobProviderCompanies { get; set; } = new List<JobProviderCompany>();
    }
}
