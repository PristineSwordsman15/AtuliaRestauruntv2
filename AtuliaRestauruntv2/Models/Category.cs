using System.ComponentModel.DataAnnotations;

namespace AtuliaRestauruntv2.Models
{
    public class Category
    {
        [Key]//Indicates primary key
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100, ErrorMessage = "Category name should be less than 100 characters")]
        public string CategoryName { get; set; }

        //Navigation property for related products
        public ICollection<Product> Products { get; set; }
    }
}
