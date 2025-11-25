using System.ComponentModel.DataAnnotations;

namespace Service_Repo_Crud.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly PublishDate { get; set; }

    }
}
