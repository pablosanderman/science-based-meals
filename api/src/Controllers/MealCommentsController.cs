using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;

namespace ScienceBasedMealsApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MealCommentsController : ControllerBase
	{
		private readonly ApiDbContext _context;

		public MealCommentsController(ApiDbContext context)
		{
			_context = context;
		}

		// GET: api/MealComments
		[HttpGet]
		public async Task<ActionResult<IEnumerable<MealComment>>> GetMealComments()
		{
			return await _context.MealComments.ToListAsync();
		}

		// GET: api/MealComments/5
		[HttpGet("{id}")]
		public async Task<ActionResult<MealComment>> GetMealComment(int id)
		{
			var mealComment = await _context.MealComments.FindAsync(id);

			if (mealComment == null)
			{
				return NotFound();
			}

			return mealComment;
		}

		// PUT: api/MealComments/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutMealComment(int id, MealComment mealComment)
		{
			if (id != mealComment.Id)
			{
				return BadRequest();
			}

			_context.Entry(mealComment).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!MealCommentExists(id))
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

		// POST: api/MealComments
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<MealComment>> PostMealComment(MealComment mealComment)
		{
			_context.MealComments.Add(mealComment);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetMealComment", new { id = mealComment.Id }, mealComment);
		}

		// DELETE: api/MealComments/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteMealComment(int id)
		{
			var mealComment = await _context.MealComments.FindAsync(id);
			if (mealComment == null)
			{
				return NotFound();
			}

			_context.MealComments.Remove(mealComment);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool MealCommentExists(int id)
		{
			return _context.MealComments.Any(e => e.Id == id);
		}
	}
}
