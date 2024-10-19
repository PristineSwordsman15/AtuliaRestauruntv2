using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace AtuliaRestauruntv2.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3, ErrorMessage = "Ingredient Name must be between 3 and 50 characters.")]
        public string Name { get; set; }
        [ValidateNever]
        public ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}
