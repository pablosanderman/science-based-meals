using System.ComponentModel.DataAnnotations;

namespace ScienceBasedMealsApi.Models.DTOs
{
	public class CreateUserDto
	{
		[Required]
		[StringLength(50, MinimumLength = 3)]
		[RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "Username can only contain letters, numbers, underscores, and hyphens")]
		public string Username { get; set; } = "";

		[Required]
		[EmailAddress]
		[StringLength(100)]
		public string Email { get; set; } = "";

		[Required]
		[StringLength(100, MinimumLength = 6)]
		public string Password { get; set; } = "";
	}
}
