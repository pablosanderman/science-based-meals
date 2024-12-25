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
    public class MealVersionsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MealVersionsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/MealVersions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MealVersion>>> GetMealVersions()
        {
            return await _context.MealVersions.ToListAsync();
        }

        // GET: api/MealVersions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MealVersion>> GetMealVersion(int id)
        {
            var mealVersion = await _context.MealVersions.FindAsync(id);

            if (mealVersion == null)
            {
                return NotFound();
            }

            return mealVersion;
        }

        // PUT: api/MealVersions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMealVersion(int id, MealVersion mealVersion)
        {
            if (id != mealVersion.Id)
            {
                return BadRequest();
            }

            _context.Entry(mealVersion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MealVersionExists(id))
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

        // POST: api/MealVersions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MealVersion>> PostMealVersion(MealVersion mealVersion)
        {
            _context.MealVersions.Add(mealVersion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMealVersion", new { id = mealVersion.Id }, mealVersion);
        }

        // DELETE: api/MealVersions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMealVersion(int id)
        {
            var mealVersion = await _context.MealVersions.FindAsync(id);
            if (mealVersion == null)
            {
                return NotFound();
            }

            _context.MealVersions.Remove(mealVersion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealVersionExists(int id)
        {
            return _context.MealVersions.Any(e => e.Id == id);
        }
    }
}
