using System.ComponentModel.DataAnnotations;

namespace ScienceBasedMealsApi.Models.DTOs
{
  public class UpdateUserDto
  {
    [StringLength(50, MinimumLength = 3)]
    [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "Username can only contain letters, numbers, underscores, and hyphens")]
    public string? Username { get; set; }

    [EmailAddress]
    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(100, MinimumLength = 6)]
    public string? Password { get; set; }

    [StringLength(500)]
    public string? Bio { get; set; }

    [Range(13, 120)]
    public int? Age { get; set; }

    [Range(50, 300)]
    public decimal? HeightCm { get; set; }

    [Range(20, 500)]
    public decimal? WeightKg { get; set; }

    [Range(1, int.MaxValue)]
    public int? GenderId { get; set; }

    [Range(1, int.MaxValue)]
    public int? ActivityLevelId { get; set; }

    [Range(1, int.MaxValue)]
    public int? GoalId { get; set; }
  }
}