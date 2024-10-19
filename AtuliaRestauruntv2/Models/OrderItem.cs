using System.ComponentModel.DataAnnotations;

namespace AtuliaRestauruntv2.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        [Required(ErrorMessage = "Order ID is required.")]
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        [Required(ErrorMessage = "Product ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Product ID must be greater than 0.")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Price must be non-negative.")]
        
        public decimal Price { get; set; }
    }
}
