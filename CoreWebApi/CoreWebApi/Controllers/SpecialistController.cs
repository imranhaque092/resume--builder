using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreWebApi.Models;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialistController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public SpecialistController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/Specialist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Specialist>>> GetSpecialists()
        {
            return await _context.Specialists.ToListAsync();
        }

        // GET: api/Specialist/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Specialist>> GetSpecialist(int id)
        {
            var specialist = await _context.Specialists.FindAsync(id);

            if (specialist == null)
            {
                return NotFound();
            }

            return specialist;
        }

        // PUT: api/Specialist/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecialist(int id, Specialist specialist)
        {
            if (id != specialist.SpecialistID)
            {
                return BadRequest();
            }

            _context.Entry(specialist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecialistExists(id))
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

        // POST: api/Specialist
        [HttpPost]
        public async Task<ActionResult<Specialist>> PostSpecialist(Specialist specialist)
        {
            _context.Specialists.Add(specialist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpecialist", new { id = specialist.SpecialistID }, specialist);
        }

        // DELETE: api/Specialist/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Specialist>> DeleteSpecialist(int id)
        {
            var specialist = await _context.Specialists.FindAsync(id);
            if (specialist == null)
            {
                return NotFound();
            }

            _context.Specialists.Remove(specialist);
            await _context.SaveChangesAsync();

            return specialist;
        }

        private bool SpecialistExists(int id)
        {
            return _context.Specialists.Any(e => e.SpecialistID == id);
        }
    }
}
