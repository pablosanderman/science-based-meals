using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScienceBasedMealsApi.Models
{
    public class Nutrient
    {
        [Key]
        public int Id { get; set; }  // nutrient_id

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public int UnitId { get; set; }

        [ForeignKey("UnitId")]
        public required Unit Unit { get; set; }

        [Precision(18, 4)]
        public decimal DailyValue { get; set; }

        public ICollection<IngredientNutrient> IngredientNutrients { get; set; } = [];
    }
}
