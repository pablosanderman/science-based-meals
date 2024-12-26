using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScienceBasedMealsApi.Models
{
	public class MealVersionIngredient
	{
		[ForeignKey("MealVersion")]
		public int MealVersionId { get; set; }

		public required MealVersion MealVersion { get; set; }

		[ForeignKey("Ingredient")]
		public int IngredientId { get; set; }

		public required Ingredient Ingredient { get; set; }

		[Required]
		[Precision(18, 4)]
		public decimal Quantity { get; set; }

		[Required]
		public int UnitId { get; set; }

		[ForeignKey("UnitId")]
		public required Unit Unit { get; set; }
	}
}
