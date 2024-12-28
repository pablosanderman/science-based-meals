using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;
using ScienceBasedMealsApi.Models.DTOs;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ScienceBasedMealsApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly ApiDbContext _context;
		private readonly IConfiguration _configuration;

		public UsersController(ApiDbContext context, IConfiguration configuration)
		{
			_context = context;
			_configuration = configuration;
		}

		private string GenerateJwtToken(User user)
		{
			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
				new Claim(JwtRegisteredClaimNames.Email, user.Email),
				new Claim("username", user.Username),
				new Claim("UserId", user.Id.ToString()),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
			};

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? throw new InvalidOperationException("JWT Key not found in configuration.")));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				issuer: _configuration["Jwt:Issuer"],
				audience: _configuration["Jwt:Audience"],
				claims: claims,
				expires: DateTime.Now.AddDays(30),
				signingCredentials: creds);

			return new JwtSecurityTokenHandler().WriteToken(token);
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
		public async Task<ActionResult<object>> PostUser(CreateUserDto createUserDto)
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
				var token = GenerateJwtToken(user);
				return CreatedAtAction("GetUser", new { id = user.Id }, new { token, user });
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

		// GET: api/Users/check-email
		[HttpGet("check-email")]
		public async Task<ActionResult<object>> CheckEmailAvailability([FromQuery] string email)
		{
			if (string.IsNullOrEmpty(email))
			{
				return BadRequest(new { message = "Email is required" });
			}

			var emailExists = await _context.Users.AnyAsync(u => u.Email == email);
			return Ok(new { available = !emailExists });
		}

		// POST: api/Users/login
		[HttpPost("login")]
		public async Task<ActionResult<object>> Login(LoginDto loginDto)
		{
			// Find user by email
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == loginDto.Email);
			if (user == null)
			{
				return Unauthorized(new { message = "Invalid email or password" });
			}

			// Verify password
			if (!BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
			{
				return Unauthorized(new { message = "Invalid email or password" });
			}

			// Update last login
			user.LastLogin = DateTime.UtcNow;
			await _context.SaveChangesAsync();

			// Generate token
			var token = GenerateJwtToken(user);
			return Ok(new { token, user });
		}

		private bool UserExists(int id)
		{
			return _context.Users.Any(e => e.Id == id);
		}
	}
}
