using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ScienceBasedMealsApi.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }  // unit_id

        [Required]
        public string UnitName { get; set; } = "";

        public string Abbreviation { get; set; } = "";

        [Required]
        [Precision(18, 4)]
        public decimal ConversionToBaseUnit { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; } = [];

        public ICollection<Nutrient> Nutrients { get; set; } = [];
    }
}
