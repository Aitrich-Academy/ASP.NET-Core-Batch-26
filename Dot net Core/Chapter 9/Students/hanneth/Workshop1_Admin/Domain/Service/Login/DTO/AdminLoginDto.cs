using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login.DTO
{
    public class AdminLoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string? Token { get; set; }
    }
}
