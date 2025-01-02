using System.Collections.Generic;

namespace ScienceBasedMealsApi.Models.DTOs
{
  public class MealSearchResponseDto
  {
    public string Name { get; set; } = "";
    public string? ImageUrl { get; set; }
    public string Visibility { get; set; } = "";
    public List<MealIngredientDto> Ingredients { get; set; } = [];
    public List<string> CookingSteps { get; set; } = [];
    public List<string> References { get; set; } = [];
  }
}