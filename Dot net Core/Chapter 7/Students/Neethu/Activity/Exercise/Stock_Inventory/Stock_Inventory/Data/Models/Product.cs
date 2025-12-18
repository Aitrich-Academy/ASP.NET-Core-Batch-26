using System.ComponentModel.DataAnnotations;

namespace Stock_Inventory.Data.Models
{
    public class Product
    {
        [Key]
        public int  ProductId { get; set; }
        [Required]
        public string ProdName { get; set; }
        [Required]
        public string Category {  get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
