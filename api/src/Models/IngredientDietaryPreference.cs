using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public class IngredientDietaryPreference
    {
        [ForeignKey("Ingredient")]
        public int IngredientId { get; set; }

        public required Ingredient Ingredient { get; set; }

        [ForeignKey("DietaryPreference")]
        public int DietaryPreferenceId { get; set; }

        public required DietaryPreference DietaryPreference { get; set; }
    }
}
