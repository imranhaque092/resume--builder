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
    public class TrainingInfornationController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public TrainingInfornationController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/TrainingInfornation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingInfornation>>> GetTrainingInfornation()
        {
            return await _context.TrainingInfornation.ToListAsync();
        }

        // GET: api/TrainingInfornation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingInfornation>> GetTrainingInfornation(int id)
        {
            var trainingInfornation = await _context.TrainingInfornation.FindAsync(id);

            if (trainingInfornation == null)
            {
                return NotFound();
            }

            return trainingInfornation;
        }

        // PUT: api/TrainingInfornation/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingInfornation(int id, TrainingInfornation trainingInfornation)
        {
            if (id != trainingInfornation.TrainingInfornationID)
            {
                return BadRequest();
            }

            _context.Entry(trainingInfornation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingInfornationExists(id))
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

        // POST: api/TrainingInfornation
        [HttpPost]
        public async Task<ActionResult<TrainingInfornation>> PostTrainingInfornation(TrainingInfornation trainingInfornation)
        {
            _context.TrainingInfornation.Add(trainingInfornation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingInfornation", new { id = trainingInfornation.TrainingInfornationID }, trainingInfornation);
        }

        // DELETE: api/TrainingInfornation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingInfornation>> DeleteTrainingInfornation(int id)
        {
            var trainingInfornation = await _context.TrainingInfornation.FindAsync(id);
            if (trainingInfornation == null)
            {
                return NotFound();
            }

            _context.TrainingInfornation.Remove(trainingInfornation);
            await _context.SaveChangesAsync();

            return trainingInfornation;
        }

        private bool TrainingInfornationExists(int id)
        {
            return _context.TrainingInfornation.Any(e => e.TrainingInfornationID == id);
        }
    }
}
