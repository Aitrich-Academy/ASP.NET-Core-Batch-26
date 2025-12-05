using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models
{
    public class JobApplication
    {
        [Key]
        public int AppId { get; set; }
        [Required]
        public int JobID { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string JobType { get; set; }
        [Required]
        public string Salary { get; set; }
       
    }
}
