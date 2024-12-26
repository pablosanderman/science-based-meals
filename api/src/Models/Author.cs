using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScienceBasedMealsApi.Models
{
	public class Author
	{
		[Key]
		public int Id { get; set; }  // author_id

		[Required]
		public string FirstName { get; set; } = "";

		[Required]
		public string LastName { get; set; } = "";

		public ICollection<ResearchReferenceAuthor> ResearchReferenceAuthors { get; set; } = [];
	}
}
