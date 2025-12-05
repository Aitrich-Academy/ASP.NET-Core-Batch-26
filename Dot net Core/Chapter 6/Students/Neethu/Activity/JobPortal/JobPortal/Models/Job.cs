using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string Company {  get; set; }
        [Required]
        public string Location { get; set; }
        [Required] 
        public string JobType { get; set; }
        [Required]
        public string Salary { get; set; }
        [Required]
        public string Requirements { get; set; }


    }
}
