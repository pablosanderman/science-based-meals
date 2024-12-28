using System;
using System.Collections.Generic;

namespace ScienceBasedMealsApi.Models.DTOs
{
  public class IngredientDto
  {
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime CreationDate { get; set; }
    public DateTime UpdatedAt { get; set; }
    public ICollection<IngredientNutrientDto> Nutrients { get; set; } = [];
  }

  public class IngredientNutrientDto
  {
    public int NutrientId { get; set; }
    public string NutrientName { get; set; } = "";
    public decimal Amount { get; set; }
    public string UnitName { get; set; } = "";
    public decimal DailyValue { get; set; }
    public decimal PercentageOfDailyValue { get; set; }
  }
}