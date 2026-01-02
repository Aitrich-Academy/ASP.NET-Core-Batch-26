using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class Industry
    {

        [Key]
        public Guid IndustryId { get; set; } = Guid.NewGuid();

        public string? Name { get; set; }

        public string? Description { get; set; } 

    }
}
