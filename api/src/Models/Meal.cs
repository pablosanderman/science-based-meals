using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
	public class Meal
	{
		[Key]
		public int Id { get; set; }  // meal_id

		[Required]
		public string Name { get; set; } = "";

		[Required]
		[ForeignKey("Creator")]
		public int CreatorId { get; set; }

		public User? Creator { get; set; }

		[Required]
		public DateTime CreationDate { get; set; }

		public DateTime UpdatedAt { get; set; }

		public ICollection<MealVersion> MealVersions { get; set; } = [];

		public ICollection<UserMeal> SavedMeals { get; set; } = [];
	}
}
