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

    [Required]
    [StringLength(500)]
    public string Bio { get; set; } = "";

    [Required]
    [Range(13, 120)]
    public int Age { get; set; }

    [Required]
    [Range(50, 300)]
    public decimal HeightCm { get; set; }

    [Required]
    [Range(20, 500)]
    public decimal WeightKg { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int GenderId { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int ActivityLevelId { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int GoalId { get; set; }
  }
}