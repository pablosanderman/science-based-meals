using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;
using ScienceBasedMealsApi.Models.DTOs;

namespace ScienceBasedMealsApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MealsController : ControllerBase
	{
		private readonly ApiDbContext _context;

		public MealsController(ApiDbContext context)
		{
			_context = context;
		}

		// GET: api/Meals/search
		[HttpGet("search")]
		public async Task<ActionResult<IEnumerable<MealSearchResponseDto>>> SearchMeals(
			[FromQuery] string query,
			[FromQuery] string? visibility,
			[FromQuery] int page = 1,
			[FromQuery] int pageSize = 20)
		{
			var mealsQuery = _context.Meals
				.Include(m => m.MealVersions)
					.ThenInclude(mv => mv.Ingredients)
						.ThenInclude(i => i.Ingredient)
				.Include(m => m.MealVersions)
					.ThenInclude(mv => mv.ResearchReferences)
				.AsQueryable();

			// Apply search filter
			if (!string.IsNullOrWhiteSpace(query))
			{
				mealsQuery = mealsQuery.Where(m =>
					m.Name.Contains(query) ||
					m.MealVersions.Any(mv =>
							mv.Instructions.Contains(query) ||
							mv.ResearchReferences.Any(r => r.ResearchReference.Title.Contains(query))
					)
				);
			}

			// Apply visibility filter
			if (!string.IsNullOrWhiteSpace(visibility))
			{
				var approvalStatus = Enum.Parse<ApprovalStatus>(visibility);
				mealsQuery = mealsQuery.Where(m => m.MealVersions
					.OrderByDescending(mv => mv.CreationDate)
					.FirstOrDefault()!.ApprovalStatus == approvalStatus);
			}

			// Apply pagination and materialize the query
			var meals = await mealsQuery
				.Skip((page - 1) * pageSize)
				.Take(pageSize)
				.ToListAsync();

			// Map to DTOs after materialization
			return meals.Select(m =>
			{
				var latestVersion = m.MealVersions.OrderByDescending(mv => mv.CreationDate).First();
				return new MealSearchResponseDto
				{
					Name = m.Name,
					ImageUrl = latestVersion.ImageUrl,
					Visibility = latestVersion.ApprovalStatus.ToString(),
					Ingredients = latestVersion.Ingredients.Select(i => new MealIngredientDto
					{
						IngredientId = i.Ingredient.Id,
						Amount = i.Quantity.ToString(),
						Unit = i.Unit.ToString()
					}).ToList(),
					CookingSteps = latestVersion.Instructions.Split('\n').ToList(),
					References = latestVersion.ResearchReferences.Select(r => r.ResearchReference.Title).ToList()
				};
			}).ToList();
		}

		// GET: api/Meals
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Meal>>> GetMeals()
		{
			return await _context.Meals.ToListAsync();
		}

		// GET: api/Meals/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Meal>> GetMeal(int id)
		{
			var meal = await _context.Meals.FindAsync(id);

			if (meal == null)
			{
				return NotFound();
			}

			return meal;
		}

		// PUT: api/Meals/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutMeal(int id, Meal meal)
		{
			if (id != meal.Id)
			{
				return BadRequest();
			}

			_context.Entry(meal).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!MealExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/Meals
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Meal>> PostMeal(Meal meal)
		{
			_context.Meals.Add(meal);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetMeal", new { id = meal.Id }, meal);
		}

		// DELETE: api/Meals/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteMeal(int id)
		{
			var meal = await _context.Meals.FindAsync(id);
			if (meal == null)
			{
				return NotFound();
			}

			_context.Meals.Remove(meal);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool MealExists(int id)
		{
			return _context.Meals.Any(e => e.Id == id);
		}
	}
}
