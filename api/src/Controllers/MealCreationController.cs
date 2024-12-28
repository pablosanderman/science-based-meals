using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;
using ScienceBasedMealsApi.Models.DTOs;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;

namespace ScienceBasedMealsApi.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class MealCreationController : ControllerBase
  {
    private readonly ApiDbContext _context;

    public MealCreationController(ApiDbContext context)
    {
      _context = context;
    }

    // POST: api/MealCreation/CreateMeal
    [HttpPost("CreateMeal")]
    public async Task<ActionResult<MealVersion>> CreateMealWithVersion(
      [FromForm] string Name,
      [FromForm] string Version,
      [FromForm] string Instructions,
      [FromForm] string Ingredients,
      [FromForm] string References,
      IFormFile? Image)
    {
      Console.WriteLine("Ingredients: " + Ingredients);
      using var transaction = await _context.Database.BeginTransactionAsync();
      try
      {
        var userId = User.FindFirst("UserId")?.Value ?? throw new InvalidOperationException("User not authenticated");
        var creator = await _context.Users.FindAsync(int.Parse(userId));
        if (creator == null)
        {
          return Unauthorized();
        }

        // Handle image upload if present
        string? imageUrl = null;
        if (Image != null)
        {
          var fileName = $"{Guid.NewGuid()}{Path.GetExtension(Image.FileName)}";
          var filePath = Path.Combine("wwwroot", "images", "meals", fileName);

          // Ensure directory exists
          Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

          using (var stream = new FileStream(filePath, FileMode.Create))
          {
            await Image.CopyToAsync(stream);
          }

          imageUrl = $"/images/meals/{fileName}";
        }

        var meal = new Meal
        {
          Name = Name,
          CreatorId = creator.Id,
          Creator = creator,
          CreationDate = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        };

        _context.Meals.Add(meal);
        await _context.SaveChangesAsync();

        var mealVersion = new MealVersion
        {
          MealId = meal.Id,
          Meal = meal,
          Version = Version,
          CreationDate = DateTime.UtcNow,
          Instructions = Instructions,
          ImageUrl = imageUrl,
          ApprovalStatus = ApprovalStatus.Pending
        };

        _context.MealVersions.Add(mealVersion);
        await _context.SaveChangesAsync();
        Console.WriteLine("Ingredients: " + Ingredients);
        var ingredientsList = JsonSerializer.Deserialize<List<MealIngredientDto>>(Ingredients);
        foreach (var ingredientDto in ingredientsList!)
        {
          Console.WriteLine("IngredientDto.IngredientId: " + ingredientDto.IngredientId);
          Console.WriteLine("IngredientDto.Amount: " + ingredientDto.Amount);
          Console.WriteLine("IngredientDto.Unit: " + ingredientDto.Unit);
          var ingredient = await _context.Ingredients.FindAsync(ingredientDto.IngredientId);
          Console.WriteLine("Ingredient: " + ingredient);
          if (ingredient == null)
          {
            throw new InvalidOperationException($"Ingredient with ID {ingredientDto.IngredientId} not found");
          }

          var unit = await _context.Units.FirstOrDefaultAsync(u => u.Name == ingredientDto.Unit);
          if (unit == null)
          {
            throw new InvalidOperationException($"Unit '{ingredientDto.Unit}' not found");
          }

          var mealVersionIngredient = new MealVersionIngredient
          {
            MealVersionId = mealVersion.Id,
            MealVersion = mealVersion,
            IngredientId = ingredient.Id,
            Ingredient = ingredient,
            Quantity = decimal.Parse(ingredientDto.Amount),
            UnitId = unit.Id,
            Unit = unit
          };
          _context.MealVersionIngredients.Add(mealVersionIngredient);
        }

        var referencesList = JsonSerializer.Deserialize<List<string>>(References);
        foreach (var referenceText in referencesList!)
        {
          var reference = new ResearchReference
          {
            Title = referenceText,
            PublicationDate = DateTime.UtcNow,
            Journal = "",
            Doi = "",
            Url = ""
          };
          _context.ResearchReferences.Add(reference);
          await _context.SaveChangesAsync();

          var mealVersionReference = new MealVersionResearchReference
          {
            MealVersionId = mealVersion.Id,
            MealVersion = mealVersion,
            ReferenceId = reference.Id,
            ResearchReference = reference
          };
          _context.MealVersionResearchReferences.Add(mealVersionReference);
        }

        await _context.SaveChangesAsync();
        await transaction.CommitAsync();

        var responseDto = new
        {
          mealVersion.Id,
          MealId = meal.Id,
          meal.Name,
          mealVersion.Version,
          mealVersion.Instructions,
          mealVersion.ImageUrl,
          mealVersion.CreationDate,
          ApprovalStatus = mealVersion.ApprovalStatus.ToString()
        };

        return Created($"/api/MealVersions/{mealVersion.Id}", responseDto);
      }
      catch (Exception ex)
      {
        await transaction.RollbackAsync();
        throw;
      }
    }
  }
}