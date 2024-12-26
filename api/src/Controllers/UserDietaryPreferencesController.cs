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
	public class UserDietaryPreferencesController : ControllerBase
	{
		private readonly ApiDbContext _context;

		public UserDietaryPreferencesController(ApiDbContext context)
		{
			_context = context;
		}

		// GET: api/UserDietaryPreferences
		[HttpGet]
		public async Task<ActionResult<IEnumerable<UserDietaryPreference>>> GetUserDietaryPreferences()
		{
			return await _context.UserDietaryPreferences.ToListAsync();
		}

		// GET: api/UserDietaryPreferences/5
		[HttpGet("{id}")]
		public async Task<ActionResult<UserDietaryPreference>> GetUserDietaryPreference(int id)
		{
			var userDietaryPreference = await _context.UserDietaryPreferences.FindAsync(id);

			if (userDietaryPreference == null)
			{
				return NotFound();
			}

			return userDietaryPreference;
		}

		// PUT: api/UserDietaryPreferences/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutUserDietaryPreference(int id, UserDietaryPreference userDietaryPreference)
		{
			if (id != userDietaryPreference.UserId)
			{
				return BadRequest();
			}

			_context.Entry(userDietaryPreference).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!UserDietaryPreferenceExists(id))
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

		// POST: api/UserDietaryPreferences
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<UserDietaryPreference>> PostUserDietaryPreference(UserDietaryPreference userDietaryPreference)
		{
			_context.UserDietaryPreferences.Add(userDietaryPreference);
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException)
			{
				if (UserDietaryPreferenceExists(userDietaryPreference.UserId))
				{
					return Conflict();
				}
				else
				{
					throw;
				}
			}

			return CreatedAtAction("GetUserDietaryPreference", new { id = userDietaryPreference.UserId }, userDietaryPreference);
		}

		// DELETE: api/UserDietaryPreferences/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUserDietaryPreference(int id)
		{
			var userDietaryPreference = await _context.UserDietaryPreferences.FindAsync(id);
			if (userDietaryPreference == null)
			{
				return NotFound();
			}

			_context.UserDietaryPreferences.Remove(userDietaryPreference);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool UserDietaryPreferenceExists(int id)
		{
			return _context.UserDietaryPreferences.Any(e => e.UserId == id);
		}
	}
}
