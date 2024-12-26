using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScienceBasedMealsApi.Models
{
	public class ResearchReference
	{
		[Key]
		public int Id { get; set; }  // reference_id

		[Required]
		public string Title { get; set; } = "";

		public DateTime PublicationDate { get; set; }

		public string Journal { get; set; } = "";

		public string Doi { get; set; } = "";

		public string Url { get; set; } = "";

		public ICollection<ResearchReferenceAuthor> ResearchReferenceAuthors { get; set; } = [];

		public ICollection<MealVersionResearchReference> MealVersionResearchReferences { get; set; } = [];

		public ICollection<IngredientResearchReference> IngredientResearchReferences { get; set; } = [];
	}
}
