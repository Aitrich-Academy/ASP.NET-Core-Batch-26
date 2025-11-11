using System.ComponentModel.DataAnnotations;

namespace Razor_Crud2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Mark {  get; set; }
        [Required]
        public string Grade { get; set; }
    }
}
