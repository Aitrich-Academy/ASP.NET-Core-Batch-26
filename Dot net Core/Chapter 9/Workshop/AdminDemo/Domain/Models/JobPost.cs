using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class JobPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid JobPostId { get; set; }

        public string? JobTitle { get; set; } 

        public string? JobSummary { get; set; }
        public DateTime PostedDate { get; set; }

        [ForeignKey(nameof(Location))]
        public Guid LocationId { get; set; }
        public virtual Location? Location { get; set; } 

        [ForeignKey(nameof(Company))]
        
        public Guid CompanyId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual JobProviderCompany? Company { get; set; } 

        [ForeignKey(nameof(JobCategory))]
        public Guid CategoryId { get; set; }
        public virtual JobCategory? JobCategory { get; set; } 

        [ForeignKey(nameof(Industry))]
        public Guid IndustryId { get; set; }
        public virtual Industry? Industry { get; set; }

        [ForeignKey(nameof(PostedByNavigation))]
        public Guid PostedBy { get; set; }
        public virtual CompanyUser? PostedByNavigation { get; set; }
       


    }
}











