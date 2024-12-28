using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScienceBasedMealsApi.Models
{
	public class Unit
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = "";

		public string Description { get; set; } = "";

		public ICollection<Nutrient> Nutrients { get; set; } = [];
	}
}
