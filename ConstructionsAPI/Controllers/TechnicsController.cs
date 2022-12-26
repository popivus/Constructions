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
    public class TechnicsController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public TechnicsController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Technics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Technics>>> GetTechnics()
        {
            return await _context.Technics.ToListAsync();
        }

        // GET: api/Technics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Technics>> GetTechnics(int id)
        {
            var technics = await _context.Technics.FindAsync(id);

            if (technics == null)
            {
                return NotFound();
            }

            return technics;
        }

        [HttpGet("search/{id}")]
        public async Task<ActionResult<IEnumerable<Technics>>> GetTechnics(string id)
        {
            var technics = await _context.Technics.Where(t => t.Name.Contains(id)).ToListAsync();

            if (technics == null)
            {
                return NotFound();
            }

            return technics;
        }

        // PUT: api/Technics/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTechnics(int id, Technics technics)
        {
            if (id != technics.ID_Technics)
            {
                return BadRequest();
            }

            _context.Entry(technics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechnicsExists(id))
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

        // POST: api/Technics
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Technics>> PostTechnics(Technics technics)
        {
            _context.Technics.Add(technics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTechnics", new { id = technics.ID_Technics }, technics);
        }

        // DELETE: api/Technics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Technics>> DeleteTechnics(int id)
        {
            var technics = await _context.Technics.FindAsync(id);
            if (technics == null)
            {
                return NotFound();
            }

            _context.Technics.Remove(technics);
            await _context.SaveChangesAsync();

            return technics;
        }

        private bool TechnicsExists(int id)
        {
            return _context.Technics.Any(e => e.ID_Technics == id);
        }
    }
}
