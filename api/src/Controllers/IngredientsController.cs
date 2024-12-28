using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;
using ScienceBasedMealsApi.Models.DTOs;

namespace ScienceBasedMealsApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class IngredientsController : ControllerBase
	{
		private readonly ApiDbContext _context;

		public IngredientsController(ApiDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<IngredientDto>>> GetIngredients()
		{
			var ingredients = await _context.Ingredients
				.Include(i => i.Nutrients)
					.ThenInclude(n => n.Nutrient)
						.ThenInclude(n => n.Unit)
				.ToListAsync();

			return Ok(ingredients.Select(i => new IngredientDto
			{
				Id = i.Id,
				Name = i.Name,
				Description = i.Description,
				CreationDate = i.CreationDate,
				UpdatedAt = i.UpdatedAt,
				Nutrients = i.Nutrients.Select(n => new IngredientNutrientDto
				{
					NutrientId = n.NutrientId,
					NutrientName = n.Nutrient?.Name ?? "",
					Amount = n.Amount,
					UnitName = n.Nutrient?.Unit?.Name ?? "",
					DailyValue = n.Nutrient?.DailyValue ?? 0,
					PercentageOfDailyValue = n.Nutrient?.DailyValue > 0
						? (n.Amount / n.Nutrient.DailyValue) * 100
						: 0
				}).ToList()
			}));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<IngredientDto>> GetIngredient(int id)
		{
			var ingredient = await _context.Ingredients
				.Include(i => i.Nutrients)
					.ThenInclude(n => n.Nutrient)
						.ThenInclude(n => n.Unit)
				.FirstOrDefaultAsync(i => i.Id == id);

			if (ingredient == null)
			{
				return NotFound();
			}

			return new IngredientDto
			{
				Id = ingredient.Id,
				Name = ingredient.Name,
				Description = ingredient.Description,
				CreationDate = ingredient.CreationDate,
				UpdatedAt = ingredient.UpdatedAt,
				Nutrients = ingredient.Nutrients.Select(n => new IngredientNutrientDto
				{
					NutrientId = n.NutrientId,
					NutrientName = n.Nutrient?.Name ?? "",
					Amount = n.Amount,
					UnitName = n.Nutrient?.Unit?.Name ?? "",
					DailyValue = n.Nutrient?.DailyValue ?? 0,
					PercentageOfDailyValue = n.Nutrient?.DailyValue > 0
						? (n.Amount / n.Nutrient.DailyValue) * 100
						: 0
				}).ToList()
			};
		}
	}
}
