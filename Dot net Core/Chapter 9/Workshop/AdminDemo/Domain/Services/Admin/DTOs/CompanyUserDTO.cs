using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.DTOs
{
    public class CompanyUserDTO
    {
        public Guid Id { get; set; }
        public Guid? Company { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? UserName { get; set; }
    }
}
