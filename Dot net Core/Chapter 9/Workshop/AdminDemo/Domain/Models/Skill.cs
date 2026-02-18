using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class Skill
    {
        public Guid SkillId { get; set; } = new Guid();

        public string? Name { get; set; }

        public string? Description { get; set; }
    }
   
}
