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
    public class Technics_ObjectsController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public Technics_ObjectsController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Technics_Objects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Technics_Objects>>> GetTechnics_Objects()
        {
            return await _context.Technics_Objects.ToListAsync();
        }

        // GET: api/Technics_Objects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Technics_Objects>> GetTechnics_Objects(int id)
        {
            var technics_Objects = await _context.Technics_Objects.FindAsync(id);

            if (technics_Objects == null)
            {
                return NotFound();
            }

            return technics_Objects;
        }

        // PUT: api/Technics_Objects/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTechnics_Objects(int id, Technics_Objects technics_Objects)
        {
            if (id != technics_Objects.ID_Technics_Objects)
            {
                return BadRequest();
            }

            _context.Entry(technics_Objects).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Technics_ObjectsExists(id))
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

        // POST: api/Technics_Objects
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Technics_Objects>> PostTechnics_Objects(Technics_Objects technics_Objects)
        {
            _context.Technics_Objects.Add(technics_Objects);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTechnics_Objects", new { id = technics_Objects.ID_Technics_Objects }, technics_Objects);
        }

        // DELETE: api/Technics_Objects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Technics_Objects>> DeleteTechnics_Objects(int id)
        {
            var technics_Objects = await _context.Technics_Objects.FindAsync(id);
            if (technics_Objects == null)
            {
                return NotFound();
            }

            _context.Technics_Objects.Remove(technics_Objects);
            await _context.SaveChangesAsync();

            return technics_Objects;
        }

        private bool Technics_ObjectsExists(int id)
        {
            return _context.Technics_Objects.Any(e => e.ID_Technics_Objects == id);
        }
    }
}
