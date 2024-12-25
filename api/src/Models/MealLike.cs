using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public class MealLike
    {
        public int Id { get; set; }  // like_id

        [ForeignKey("MealVersion")]
        public int MealVersionId { get; set; }

        public required MealVersion MealVersion { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public required User User { get; set; }

        public DateTime LikedAt { get; set; }
    }
}
