using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConstructionsAPI.Data;
using ConstructionsAPI.Models;

namespace ConstructionsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrigadesController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public BrigadesController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Brigades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brigade>>> GetBrigade()
        {
            return await _context.Brigade.ToListAsync();
        }

        // GET: api/Brigades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brigade>> GetBrigade(int id)
        {
            var brigade = await _context.Brigade.FindAsync(id);

            if (brigade == null)
            {
                return NotFound();
            }

            return brigade;
        }

        [HttpGet("search/{id}")]
        public async Task<ActionResult<IEnumerable<Brigade>>> GetBrigade(string id)
        {
            var brigades = await _context.Brigade.Where(s => s.Name.Contains(id)).ToListAsync();

            if (brigades == null)
            {
                return NotFound();
            }

            return brigades;
        }

        // PUT: api/Brigades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrigade(int id, Brigade brigade)
        {
            if (id != brigade.ID_Brigade)
            {
                return BadRequest();
            }

            _context.Entry(brigade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrigadeExists(id))
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

        // POST: api/Brigades
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Brigade>> PostBrigade(Brigade brigade)
        {
            _context.Brigade.Add(brigade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrigade", new { id = brigade.ID_Brigade }, brigade);
        }

        // DELETE: api/Brigades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Brigade>> DeleteBrigade(int id)
        {
            var brigade = await _context.Brigade.FindAsync(id);
            if (brigade == null)
            {
                return NotFound();
            }

            _context.Brigade.Remove(brigade);
            await _context.SaveChangesAsync();

            return brigade;
        }

        private bool BrigadeExists(int id)
        {
            return _context.Brigade.Any(e => e.ID_Brigade == id);
        }
    }
}
