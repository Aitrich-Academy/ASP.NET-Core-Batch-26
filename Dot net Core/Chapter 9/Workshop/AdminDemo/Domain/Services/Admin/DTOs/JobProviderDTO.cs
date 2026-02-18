using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.DTOs
{
    public class JobProviderDTO
    {
        public Guid Id { get; set; }
        public string? LegalName { get; set; } 

        public string? Summary { get; set; } 

        public Guid IndustryId { get; set; }

        public string? Email { get; set; } 

        public long Phone { get; set; }

        public string Address { get; set; } = null!;

        public string Website { get; set; } = null!;

        public Guid Location { get; set; }
    }
}
