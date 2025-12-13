using System.ComponentModel.DataAnnotations;

namespace Razor_Workshop.Model
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
        public int SalaryRange { get; set; }
        [Required]
        public string JobDescription{get;set;}
        [Required]
        public string Requirements {  get; set; }
    }
}
