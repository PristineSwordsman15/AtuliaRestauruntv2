using System.ComponentModel.DataAnnotations;

namespace AtuliaRestauruntv2.Models
{
    public class ProductIngredient
    {
       

        [Required(ErrorMessage = "Product ID is required.")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
