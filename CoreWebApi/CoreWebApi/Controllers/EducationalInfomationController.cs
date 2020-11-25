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
    public class EducationalInfomationController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public EducationalInfomationController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/EducationalInfomation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EducationalInfomation>>> GetEducationalInfomations()
        {
            return await _context.EducationalInfomations.ToListAsync();
        }

        // GET: api/EducationalInfomation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EducationalInfomation>> GetEducationalInfomation(int id)
        {
            var educationalInfomation = await _context.EducationalInfomations.FindAsync(id);

            if (educationalInfomation == null)
            {
                return NotFound();
            }

            return educationalInfomation;
        }

        // PUT: api/EducationalInfomation/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducationalInfomation(int id, EducationalInfomation educationalInfomation)
        {
            if (id != educationalInfomation.EducationalInfomationID)
            {
                return BadRequest();
            }

            _context.Entry(educationalInfomation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationalInfomationExists(id))
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

        // POST: api/EducationalInfomation
        [HttpPost]
        public async Task<ActionResult<EducationalInfomation>> PostEducationalInfomation(EducationalInfomation educationalInfomation)
        {
            _context.EducationalInfomations.Add(educationalInfomation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEducationalInfomation", new { id = educationalInfomation.EducationalInfomationID }, educationalInfomation);
        }

        // DELETE: api/EducationalInfomation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EducationalInfomation>> DeleteEducationalInfomation(int id)
        {
            var educationalInfomation = await _context.EducationalInfomations.FindAsync(id);
            if (educationalInfomation == null)
            {
                return NotFound();
            }

            _context.EducationalInfomations.Remove(educationalInfomation);
            await _context.SaveChangesAsync();

            return educationalInfomation;
        }

        private bool EducationalInfomationExists(int id)
        {
            return _context.EducationalInfomations.Any(e => e.EducationalInfomationID == id);
        }
    }
}
