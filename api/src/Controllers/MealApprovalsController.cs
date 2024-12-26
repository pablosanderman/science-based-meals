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
	public class MealApprovalsController : ControllerBase
	{
		private readonly ApiDbContext _context;

		public MealApprovalsController(ApiDbContext context)
		{
			_context = context;
		}

		// GET: api/MealApprovals
		[HttpGet]
		public async Task<ActionResult<IEnumerable<MealApproval>>> GetMealApprovals()
		{
			return await _context.MealApprovals.ToListAsync();
		}

		// GET: api/MealApprovals/5
		[HttpGet("{id}")]
		public async Task<ActionResult<MealApproval>> GetMealApproval(int id)
		{
			var mealApproval = await _context.MealApprovals.FindAsync(id);

			if (mealApproval == null)
			{
				return NotFound();
			}

			return mealApproval;
		}

		// PUT: api/MealApprovals/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutMealApproval(int id, MealApproval mealApproval)
		{
			if (id != mealApproval.Id)
			{
				return BadRequest();
			}

			_context.Entry(mealApproval).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!MealApprovalExists(id))
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

		// POST: api/MealApprovals
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<MealApproval>> PostMealApproval(MealApproval mealApproval)
		{
			_context.MealApprovals.Add(mealApproval);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetMealApproval", new { id = mealApproval.Id }, mealApproval);
		}

		// DELETE: api/MealApprovals/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteMealApproval(int id)
		{
			var mealApproval = await _context.MealApprovals.FindAsync(id);
			if (mealApproval == null)
			{
				return NotFound();
			}

			_context.MealApprovals.Remove(mealApproval);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool MealApprovalExists(int id)
		{
			return _context.MealApprovals.Any(e => e.Id == id);
		}
	}
}
