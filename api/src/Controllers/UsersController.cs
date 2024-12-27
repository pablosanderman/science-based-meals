using System;
using System.Collections.Generic;
using System.Linq;
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
	public class UsersController : ControllerBase
	{
		private readonly ApiDbContext _context;

		public UsersController(ApiDbContext context)
		{
			_context = context;
		}

		// GET: api/Users
		[HttpGet]
		public async Task<ActionResult<IEnumerable<User>>> GetUsers()
		{
			return await _context.Users.ToListAsync();
		}

		// GET: api/Users/5
		[HttpGet("{id}")]
		public async Task<ActionResult<User>> GetUser(int id)
		{
			var user = await _context.Users.FindAsync(id);

			if (user == null)
			{
				return NotFound();
			}

			return user;
		}

		// PUT: api/Users/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutUser(int id, UpdateUserDto updateUserDto)
		{
			var user = await _context.Users.FindAsync(id);
			if (user == null)
			{
				return NotFound();
			}

			// Validate unique constraints if email or username is being updated
			if (updateUserDto.Email != null && updateUserDto.Email != user.Email)
			{
				if (await _context.Users.AnyAsync(u => u.Email == updateUserDto.Email))
				{
					return Conflict(new { message = "A user with this email already exists." });
				}
			}

			if (updateUserDto.Username != null && updateUserDto.Username != user.Username)
			{
				if (await _context.Users.AnyAsync(u => u.Username == updateUserDto.Username))
				{
					return Conflict(new { message = "A user with this username already exists." });
				}
			}

			// Update only the provided fields
			if (updateUserDto.Username != null) user.Username = updateUserDto.Username;
			if (updateUserDto.Email != null) user.Email = updateUserDto.Email;
			if (updateUserDto.Password != null) user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(updateUserDto.Password);

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException ex)
			{
				// In case of race condition where email or username was taken between our check and save
				if (ex.InnerException?.Message.Contains("IX_Users_Email") == true)
				{
					return Conflict(new { message = "A user with this email already exists." });
				}
				if (ex.InnerException?.Message.Contains("IX_Users_Username") == true)
				{
					return Conflict(new { message = "A user with this username already exists." });
				}
				throw;
			}

			return NoContent();
		}

		// POST: api/Users
		[HttpPost]
		public async Task<ActionResult<User>> PostUser(CreateUserDto createUserDto)
		{
			// Check if email already exists
			if (await _context.Users.AnyAsync(u => u.Email == createUserDto.Email))
			{
				return Conflict(new { message = "A user with this email already exists." });
			}

			// Check if username already exists
			if (await _context.Users.AnyAsync(u => u.Username == createUserDto.Username))
			{
				return Conflict(new { message = "A user with this username already exists." });
			}

			// Create new user
			var user = new User
			{
				Username = createUserDto.Username,
				Email = createUserDto.Email,
				PasswordHash = BCrypt.Net.BCrypt.HashPassword(createUserDto.Password),
				RoleId = 1, // Default role (User)
				JoinDate = DateTime.UtcNow,
				LastLogin = DateTime.UtcNow
			};

			_context.Users.Add(user);
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException ex)
			{
				// In case of race condition where email or username was created between our check and save
				if (ex.InnerException?.Message.Contains("IX_Users_Email") == true)
				{
					return Conflict(new { message = "A user with this email already exists." });
				}
				if (ex.InnerException?.Message.Contains("IX_Users_Username") == true)
				{
					return Conflict(new { message = "A user with this username already exists." });
				}
				throw;
			}

			return CreatedAtAction("GetUser", new { id = user.Id }, user);
		}

		// DELETE: api/Users/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUser(int id)
		{
			var user = await _context.Users.FindAsync(id);
			if (user == null)
			{
				return NotFound();
			}

			_context.Users.Remove(user);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool UserExists(int id)
		{
			return _context.Users.Any(e => e.Id == id);
		}
	}
}
