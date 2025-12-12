using System.ComponentModel.DataAnnotations;

namespace Blazor_Crud_Activity3.Data.Models
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
