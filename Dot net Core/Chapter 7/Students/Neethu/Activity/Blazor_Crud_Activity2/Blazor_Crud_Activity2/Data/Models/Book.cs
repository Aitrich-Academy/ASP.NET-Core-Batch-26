using System.ComponentModel.DataAnnotations;

namespace Blazor_Crud_Activity2.Data.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Author { get; set; }
    }
}
