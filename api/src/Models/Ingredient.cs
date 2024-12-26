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

		[Required]
		public DateTime CreationDate { get; set; }

		public DateTime UpdatedAt { get; set; }

		public ICollection<IngredientNutrient> Nutrients { get; set; } = [];

		public ICollection<IngredientDietaryPreference> DietaryPreferences { get; set; } = [];

		public ICollection<IngredientResearchReference> ResearchReferences { get; set; } = [];

		public ICollection<MealVersionIngredient> MealVersions { get; set; } = [];
	}
}
