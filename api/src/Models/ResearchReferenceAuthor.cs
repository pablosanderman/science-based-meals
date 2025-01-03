using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
	public class ResearchReferenceAuthor
	{
		[ForeignKey("ResearchReference")]
		public int ReferenceId { get; set; }

		public ResearchReference? ResearchReference { get; set; }

		[ForeignKey("Author")]
		public int AuthorId { get; set; }

		public Author? Author { get; set; }

		public int AuthorOrder { get; set; }
	}
}
