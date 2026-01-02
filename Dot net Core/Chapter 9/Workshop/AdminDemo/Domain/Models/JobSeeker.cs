using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class JobSeeker
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid JobSeekerId { get; set; }


        public string? UserName { get; set; }

        public string? FirstName { get; set; } 

        public string? LastName { get; set; }

        public string? Phone { get; set; } 

        public string? Email { get; set; } 

        
        public byte[]? Image { get; set; } 
        public int Role { get; set; }
       

    }
}







