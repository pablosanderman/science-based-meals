using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }  // ingredient_id

        [Required]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public string ExternalId { get; set; } = "";

        public string Source { get; set; } = "";

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public int DefaultUnitId { get; set; }

        [ForeignKey("DefaultUnitId")]
        public required Unit DefaultUnit { get; set; }

        public ICollection<MealIngredient> MealIngredients { get; set; } = [];

        public ICollection<IngredientNutrient> IngredientNutrients { get; set; } = [];

        public ICollection<IngredientResearchReference> IngredientResearchReferences { get; set; } = [];

        public ICollection<IngredientDietaryPreference> IngredientDietaryPreferences { get; set; } = [];
    }
}
