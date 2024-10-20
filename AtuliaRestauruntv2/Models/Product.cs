using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtuliaRestauruntv2.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Product ID must be greater than 0.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 100 characters.")]
        public string? ProductName { get; set; }
        [StringLength(2000, ErrorMessage = "Product description must be less than 2000 characters.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Product price is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Product price must be non-negative.")]

        public decimal Price { get; set; }
        [Required(ErrorMessage = "Product stock quantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Product stock quantity must be non-negative.")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Category ID is required.")]
        public int CategoryId { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";

        [ValidateNever]
        public Category? Category { get; set; }//A product belongs to a category 

        [ValidateNever]
        public ICollection<OrderItem> OrderItems { get; set; } // A product is or can be in many order items
        [ValidateNever]
        public ICollection<ProductIngredient>? ProductIngredients { get; set; } //A  product can have many ingredients

    }
}
