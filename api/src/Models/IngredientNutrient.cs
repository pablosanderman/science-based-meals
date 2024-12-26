using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScienceBasedMealsApi.Models
{
	public class IngredientNutrient
	{
		[ForeignKey("Ingredient")]
		public int IngredientId { get; set; }

		public required Ingredient Ingredient { get; set; }

		[ForeignKey("Nutrient")]
		public int NutrientId { get; set; }

		public required Nutrient Nutrient { get; set; }

		[Precision(18, 4)]
		public decimal Amount { get; set; }  // In unit specified by Nutrient.UnitId
	}
}
