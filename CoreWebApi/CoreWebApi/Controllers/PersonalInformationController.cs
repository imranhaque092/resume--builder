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
    public class PersonalInformationController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public PersonalInformationController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/PersonalInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonalInformation>>> GetPersonalInformations()
        {
            return await _context.PersonalInformations.ToListAsync();
        }

        // GET: api/PersonalInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalInformation>> GetPersonalInformation(int id)
        {
            var personalInformation = await _context.PersonalInformations.FindAsync(id);

            if (personalInformation == null)
            {
                return NotFound();
            }

            return personalInformation;
        }

        // PUT: api/PersonalInformation/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalInformation(int id, PersonalInformation personalInformation)
        {
            if (id != personalInformation.PersonalInformationID)
            {
                return BadRequest();
            }

            _context.Entry(personalInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalInformationExists(id))
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

        // POST: api/PersonalInformation
        [HttpPost]
        public async Task<ActionResult<PersonalInformation>> PostPersonalInformation(PersonalInformation personalInformation)
        {
            _context.PersonalInformations.Add(personalInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonalInformation", new { id = personalInformation.PersonalInformationID }, personalInformation);
        }

        // DELETE: api/PersonalInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PersonalInformation>> DeletePersonalInformation(int id)
        {
            var personalInformation = await _context.PersonalInformations.FindAsync(id);
            if (personalInformation == null)
            {
                return NotFound();
            }

            _context.PersonalInformations.Remove(personalInformation);
            await _context.SaveChangesAsync();

            return personalInformation;
        }

        private bool PersonalInformationExists(int id)
        {
            return _context.PersonalInformations.Any(e => e.PersonalInformationID == id);
        }
    }
}
