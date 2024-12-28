using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace ScienceBasedMealsApi.Models.DTOs
{
  public class CreateMealDto
  {
    public string Name { get; set; } = "";
    public string Version { get; set; } = "1.0";
    public string Instructions { get; set; } = "";
    public IFormFile? Image { get; set; }
    public List<MealIngredientDto> Ingredients { get; set; } = [];
    public List<string> References { get; set; } = [];
  }
}