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
    public class Composition_brigadeController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public Composition_brigadeController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Composition_brigade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Composition_brigade>>> GetComposition_brigade()
        {
            return await _context.Composition_brigade.ToListAsync();
        }

        // GET: api/Composition_brigade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Composition_brigade>> GetComposition_brigade(int id)
        {
            var composition_brigade = await _context.Composition_brigade.FindAsync(id);

            if (composition_brigade == null)
            {
                return NotFound();
            }

            return composition_brigade;
        }

        // PUT: api/Composition_brigade/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComposition_brigade(int id, Composition_brigade composition_brigade)
        {
            if (id != composition_brigade.ID_Composition_brigade)
            {
                return BadRequest();
            }

            _context.Entry(composition_brigade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Composition_brigadeExists(id))
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

        // POST: api/Composition_brigade
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Composition_brigade>> PostComposition_brigade(Composition_brigade composition_brigade)
        {
            _context.Composition_brigade.Add(composition_brigade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComposition_brigade", new { id = composition_brigade.ID_Composition_brigade }, composition_brigade);
        }

        // DELETE: api/Composition_brigade/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Composition_brigade>> DeleteComposition_brigade(int id)
        {
            var composition_brigade = await _context.Composition_brigade.FindAsync(id);
            if (composition_brigade == null)
            {
                return NotFound();
            }

            _context.Composition_brigade.Remove(composition_brigade);
            await _context.SaveChangesAsync();

            return composition_brigade;
        }

        private bool Composition_brigadeExists(int id)
        {
            return _context.Composition_brigade.Any(e => e.ID_Composition_brigade == id);
        }
    }
}
