using System.ComponentModel.DataAnnotations;

namespace Activity1_Direct.Data.Model
{
    public class Book
    {
        [Key]
        public int Id{get; set;}
        [Required]
        public string Title{get; set;}
        [Required]
        public string Author{get; set;}
    }
}
