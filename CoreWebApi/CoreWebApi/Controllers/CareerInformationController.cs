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
    public class CareerInformationController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public CareerInformationController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/CareerInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CareerInformation>>> GetCareerInformations()
        {
            return await _context.CareerInformations.ToListAsync();
        }

        // GET: api/CareerInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CareerInformation>> GetCareerInformation(int id)
        {
            var careerInformation = await _context.CareerInformations.FindAsync(id);

            if (careerInformation == null)
            {
                return NotFound();
            }

            return careerInformation;
        }

        // PUT: api/CareerInformation/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCareerInformation(int id, CareerInformation careerInformation)
        {
            if (id != careerInformation.CareerInformationID)
            {
                return BadRequest();
            }

            _context.Entry(careerInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CareerInformationExists(id))
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

        // POST: api/CareerInformation
        [HttpPost]
        public async Task<ActionResult<CareerInformation>> PostCareerInformation(CareerInformation careerInformation)
        {
            _context.CareerInformations.Add(careerInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCareerInformation", new { id = careerInformation.CareerInformationID }, careerInformation);
        }

        // DELETE: api/CareerInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CareerInformation>> DeleteCareerInformation(int id)
        {
            var careerInformation = await _context.CareerInformations.FindAsync(id);
            if (careerInformation == null)
            {
                return NotFound();
            }

            _context.CareerInformations.Remove(careerInformation);
            await _context.SaveChangesAsync();

            return careerInformation;
        }

        private bool CareerInformationExists(int id)
        {
            return _context.CareerInformations.Any(e => e.CareerInformationID == id);
        }
    }
}
