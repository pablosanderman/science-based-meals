using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
	public class IngredientDietaryPreference
	{
		[ForeignKey("Ingredient")]
		public int IngredientId { get; set; }

		public Ingredient? Ingredient { get; set; }

		[ForeignKey("DietaryPreference")]
		public int DietaryPreferenceId { get; set; }

		public DietaryPreference? DietaryPreference { get; set; }
	}
}
