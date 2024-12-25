using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScienceBasedMealsApi.Models
{
    public class DietaryPreference
    {
        [Key]
        public int Id { get; set; }  // preference_id

        [Required]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public ICollection<UserDietaryPreference> UserDietaryPreferences { get; set; } = [];

        public ICollection<IngredientDietaryPreference> IngredientDietaryPreferences { get; set; } = [];
    }
}
