using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
	public class MealComment
	{
		[Key]
		public int Id { get; set; }  // comment_id

		[Required]
		public int MealVersionId { get; set; }

		[ForeignKey("MealVersionId")]
		public required MealVersion MealVersion { get; set; }

		[Required]
		public int UserId { get; set; }

		[ForeignKey("UserId")]
		public required User User { get; set; }

		[Required]
		public string CommentText { get; set; } = "";

		[Required]
		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }

		public int? ParentCommentId { get; set; }

		[ForeignKey("ParentCommentId")]
		public required MealComment ParentComment { get; set; }

		public ICollection<MealComment> Replies { get; set; } = [];
	}
}
