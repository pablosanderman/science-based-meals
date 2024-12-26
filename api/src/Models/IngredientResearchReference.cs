using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
	public class IngredientResearchReference
	{
		[ForeignKey("Ingredient")]
		public int IngredientId { get; set; }

		public Ingredient? Ingredient { get; set; }

		[ForeignKey("ResearchReference")]
		public int ReferenceId { get; set; }

		public ResearchReference? ResearchReference { get; set; }
	}
}
