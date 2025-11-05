using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFA_FOREIGNKEY.Models
{
    public class Department
    {
        [Key]
        public int DId { get; set; }
        [Required]
        public string DName { get; set; }
    }
}
