using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
	public class MealVersion
	{
		[Key]
		public int Id { get; set; }  // meal_version_id

		[ForeignKey("Meal")]
		public int MealId { get; set; }

		public required Meal Meal { get; set; }

		[Required]
		public string Version { get; set; } = "";

		[Required]
		public DateTime CreationDate { get; set; }

		public string Instructions { get; set; } = "";

		public string? ImageUrl { get; set; }

		public ApprovalStatus ApprovalStatus { get; set; }

		public DateTime? ApprovalDate { get; set; }

		public ICollection<MealVersionResearchReference> ResearchReferences { get; set; } = [];

		public ICollection<MealVersionIngredient> Ingredients { get; set; } = [];
	}
}
