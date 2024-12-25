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
    public class MealLikesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MealLikesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/MealLikes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MealLike>>> GetMealLikes()
        {
            return await _context.MealLikes.ToListAsync();
        }

        // GET: api/MealLikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MealLike>> GetMealLike(int id)
        {
            var mealLike = await _context.MealLikes.FindAsync(id);

            if (mealLike == null)
            {
                return NotFound();
            }

            return mealLike;
        }

        // PUT: api/MealLikes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMealLike(int id, MealLike mealLike)
        {
            if (id != mealLike.Id)
            {
                return BadRequest();
            }

            _context.Entry(mealLike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MealLikeExists(id))
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

        // POST: api/MealLikes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MealLike>> PostMealLike(MealLike mealLike)
        {
            _context.MealLikes.Add(mealLike);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMealLike", new { id = mealLike.Id }, mealLike);
        }

        // DELETE: api/MealLikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMealLike(int id)
        {
            var mealLike = await _context.MealLikes.FindAsync(id);
            if (mealLike == null)
            {
                return NotFound();
            }

            _context.MealLikes.Remove(mealLike);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealLikeExists(int id)
        {
            return _context.MealLikes.Any(e => e.Id == id);
        }
    }
}
