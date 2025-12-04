using System.ComponentModel.DataAnnotations;

namespace JobManagement_Portal.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string EmploymentType { get; set; }
        [Required]
        public string SalaryRange { get; set; }
        [Required]
        public string JobDescription { get; set; }
        [Required]
        public string Requirements { get; set; }
    }
}
