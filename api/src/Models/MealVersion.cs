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

        [Required]
        public int MealId { get; set; }

        [ForeignKey("MealId")]
        public required Meal Meal { get; set; }

        [Required]
        public int VersionNumber { get; set; }

        public int CreatorUserId { get; set; }

        [ForeignKey("CreatorUserId")]
        public required User CreatorUser { get; set; }

        public string Description { get; set; } = "";

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime UpdatedAt { get; set; }

        public ICollection<MealIngredient> MealIngredients { get; set; } = [];

        public ICollection<MealApproval> MealApprovals { get; set; } = [];

        public ICollection<MealVersionResearchReference> MealVersionResearchReferences { get; set; } = [];

        public ICollection<MealComment> MealComments { get; set; } = [];

        public ICollection<MealLike> MealLikes { get; set; } = [];
    }
}
