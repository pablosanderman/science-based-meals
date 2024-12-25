using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public class IngredientResearchReference
    {
        [ForeignKey("Ingredient")]
        public int IngredientId { get; set; }

        public required Ingredient Ingredient { get; set; }

        [ForeignKey("ResearchReference")]
        public int ReferenceId { get; set; }

        public required ResearchReference ResearchReference { get; set; }
    }
}
