using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Username { get; set; } = "";

		[Required]
		public string Email { get; set; } = "";

		[Required]
		public string PasswordHash { get; set; } = "";

		[Required]
		public DateTime JoinDate { get; set; }

		[Required]
		public DateTime LastLogin { get; set; }

		[Required]
		public int RoleId { get; set; }

		[ForeignKey("RoleId")]
		public Role? Role { get; set; }

		public ICollection<UserMeal> SavedMeals { get; set; } = [];

		public ICollection<UserConnection> Followers { get; set; } = [];

		public ICollection<UserConnection> Following { get; set; } = [];

		public ICollection<UserDietaryPreference> UserDietaryPreferences { get; set; } = [];

		public ICollection<Notification> Notifications { get; set; } = [];

		public ICollection<MealVersion> MealVersionsCreated { get; set; } = [];

		public ICollection<MealApproval> MealApprovals { get; set; } = [];

		public ICollection<MealComment> MealComments { get; set; } = [];

		public ICollection<MealLike> MealLikes { get; set; } = [];
	}
}
