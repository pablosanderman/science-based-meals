using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScienceBasedMealsApi.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }  // meal_id

        [Required]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime UpdatedAt { get; set; }

        public ICollection<MealVersion> MealVersions { get; set; } = [];

        public ICollection<SavedMeal> SavedMeals { get; set; } = [];
    }
}
