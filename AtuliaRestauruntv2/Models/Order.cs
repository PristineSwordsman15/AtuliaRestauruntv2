using System.ComponentModel.DataAnnotations;

namespace AtuliaRestauruntv2.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Order Date is required")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Total amount is required.")]
        [Range(0.01, int.MaxValue, ErrorMessage = "Total amount must be greater than 0.")]
        public decimal TotalAmount { get; set; }

        // Reference to Product
        [Required(ErrorMessage = "Product selection is required.")]
        public int ProductId { get; set; }

        // Navigation property
        public Product? Product { get; set; }
    }
}
