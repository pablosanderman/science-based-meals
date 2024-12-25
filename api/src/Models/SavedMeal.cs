using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public class UserMeal
    {
        [ForeignKey("User")]
        public int UserId { get; set; }

        public required User User { get; set; }

        [ForeignKey("Meal")]
        public int MealId { get; set; }

        public required Meal Meal { get; set; }

        public DateTime SavedDate { get; set; }
    }
}
