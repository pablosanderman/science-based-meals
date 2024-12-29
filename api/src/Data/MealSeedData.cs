using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;

namespace ScienceBasedMealsApi.Data;

public static class MealSeedData
{
  public static void SeedMealData(this ModelBuilder modelBuilder)
  {
    SeedMeals(modelBuilder);
    SeedMealVersions(modelBuilder);
    SeedMealApprovals(modelBuilder);
  }

  private static void SeedMeals(ModelBuilder modelBuilder)
  {
    var baseDate = DateTime.UtcNow.Date;
    var meals = new[]
    {
        // Admin's meals
        CreateMeal(1, "High Protein Breakfast Bowl", 1, baseDate),
        CreateMeal(2, "Mediterranean Quinoa Salad", 1, baseDate),
        
        // Reviewer1's meals
        CreateMeal(3, "Lean Muscle Building Dinner", 2, baseDate),
        CreateMeal(4, "Vegan Power Bowl", 2, baseDate),
        
        // Reviewer2's meals
        CreateMeal(5, "Keto-Friendly Lunch Plate", 3, baseDate),
        CreateMeal(6, "Post-Workout Recovery Meal", 3, baseDate),
        
        // Regular users' meals
        CreateMeal(7, "Low-Carb Protein Pack", 4, baseDate),
        CreateMeal(8, "Balanced Nutrition Bowl", 5, baseDate),
        CreateMeal(9, "Athlete's Energy Plate", 6, baseDate),
        CreateMeal(10, "Brain Boost Breakfast", 7, baseDate),
        CreateMeal(11, "Immune System Supporter", 8, baseDate),
        CreateMeal(12, "Muscle Mass Builder", 9, baseDate),
        CreateMeal(13, "Weight Loss Friendly Plate", 10, baseDate),
        CreateMeal(14, "High Fiber Vegetarian Bowl", 4, baseDate),
        CreateMeal(15, "Omega-3 Rich Seafood Plate", 5, baseDate),
        CreateMeal(16, "Anti-Inflammatory Diet Bowl", 6, baseDate),
        CreateMeal(17, "Sports Performance Plate", 7, baseDate),
        CreateMeal(18, "Gut Health Optimizer", 8, baseDate),
        CreateMeal(19, "Antioxidant Rich Bowl", 9, baseDate),
        CreateMeal(20, "Balanced Macros Plate", 10, baseDate)
    };

    modelBuilder.Entity<Meal>().HasData(meals);
  }

  private static void SeedMealVersions(ModelBuilder modelBuilder)
  {
    var baseDate = DateTime.UtcNow.Date;
    var mealVersions = new List<MealVersion>();

    // Create one version for each meal
    for (int i = 1; i <= 20; i++)
    {
      mealVersions.Add(new MealVersion
      {
        Id = i,
        MealId = i,
        Version = "1.0",
        CreationDate = baseDate,
        Instructions = "1. Prepare ingredients\n2. Cook according to instructions\n3. Plate and serve",
        ImageUrl = null,
        ApprovalStatus = null,
        ApprovalDate = null
      });
    }

    modelBuilder.Entity<MealVersion>().HasData(mealVersions);
  }

  private static void SeedMealApprovals(ModelBuilder modelBuilder)
  {
    var baseDate = DateTime.UtcNow.Date;
    var approvals = new List<MealApproval>();

    // Create approvals for first 10 meals (mix of statuses)
    for (int i = 1; i <= 10; i++)
    {
      var status = i switch
      {
        <= 3 => ApprovalStatus.Approved,
        <= 6 => ApprovalStatus.Pending,
        _ => ApprovalStatus.Rejected
      };

      var critique = status switch
      {
        ApprovalStatus.Approved => "Excellent nutritional balance and scientific backing.",
        ApprovalStatus.Pending => "Under review by nutrition team.",
        ApprovalStatus.Rejected => "Needs more scientific evidence for health claims.",
        _ => ""
      };

      approvals.Add(new MealApproval
      {
        Id = i,
        MealVersionId = i,
        ReviewerUserId = (i % 3) + 1, // Rotate between reviewers 1, 2, and 3
        ApprovalStatus = status,
        Critique = critique,
        ApprovalDate = baseDate
      });
    }

    modelBuilder.Entity<MealApproval>().HasData(approvals);
  }

  private static Meal CreateMeal(int id, string name, int creatorId, DateTime baseDate)
  {
    return new Meal
    {
      Id = id,
      Name = name,
      CreatorId = creatorId,
      CreationDate = baseDate,
      UpdatedAt = baseDate
    };
  }
}