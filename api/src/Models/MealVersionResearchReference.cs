using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
	public class MealVersionResearchReference
	{
		[ForeignKey("MealVersion")]
		public int MealVersionId { get; set; }

		public required MealVersion MealVersion { get; set; }

		[ForeignKey("ResearchReference")]
		public int ReferenceId { get; set; }

		public required ResearchReference ResearchReference { get; set; }
	}
}
