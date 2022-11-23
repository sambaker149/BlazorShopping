using System.ComponentModel.DataAnnotations;

namespace BlazorShopping.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required, StringLength(60)]
        public string Name { get; set; } = String.Empty;

        [StringLength(255)]
        public string? Description { get; set; } = String.Empty;

        [Required, Range(0,100.00)]
        public decimal Price { get; set; } = 0;
    }
}