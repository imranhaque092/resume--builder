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
    public class RefereeInformationController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public RefereeInformationController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/RefereeInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RefereeInformation>>> GetRefereeInformations()
        {
            return await _context.RefereeInformations.ToListAsync();
        }

        // GET: api/RefereeInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RefereeInformation>> GetRefereeInformation(int id)
        {
            var refereeInformation = await _context.RefereeInformations.FindAsync(id);

            if (refereeInformation == null)
            {
                return NotFound();
            }

            return refereeInformation;
        }

        // PUT: api/RefereeInformation/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRefereeInformation(int id, RefereeInformation refereeInformation)
        {
            if (id != refereeInformation.RefereeInformationID)
            {
                return BadRequest();
            }

            _context.Entry(refereeInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefereeInformationExists(id))
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

        // POST: api/RefereeInformation
        [HttpPost]
        public async Task<ActionResult<RefereeInformation>> PostRefereeInformation(RefereeInformation refereeInformation)
        {
            _context.RefereeInformations.Add(refereeInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRefereeInformation", new { id = refereeInformation.RefereeInformationID }, refereeInformation);
        }

        // DELETE: api/RefereeInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RefereeInformation>> DeleteRefereeInformation(int id)
        {
            var refereeInformation = await _context.RefereeInformations.FindAsync(id);
            if (refereeInformation == null)
            {
                return NotFound();
            }

            _context.RefereeInformations.Remove(refereeInformation);
            await _context.SaveChangesAsync();

            return refereeInformation;
        }

        private bool RefereeInformationExists(int id)
        {
            return _context.RefereeInformations.Any(e => e.RefereeInformationID == id);
        }
    }
}
