using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ScienceBasedMealsApi.Models.DTOs
{
  public class MealIngredientDto
  {
    [Required]
    [JsonPropertyName("ingredientId")]
    public int IngredientId { get; set; }

    [Required]
    [JsonPropertyName("amount")]
    public string Amount { get; set; } = "";

    [Required]
    [JsonPropertyName("unit")]
    public string Unit { get; set; } = "";
  }
}