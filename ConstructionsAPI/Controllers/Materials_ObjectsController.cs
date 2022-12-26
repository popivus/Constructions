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
    public class Materials_ObjectsController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public Materials_ObjectsController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Materials_Objects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materials_Objects>>> GetMaterials_Objects()
        {
            return await _context.Materials_Objects.ToListAsync();
        }

        // GET: api/Materials_Objects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materials_Objects>> GetMaterials_Objects(int id)
        {
            var materials_Objects = await _context.Materials_Objects.FindAsync(id);

            if (materials_Objects == null)
            {
                return NotFound();
            }

            return materials_Objects;
        }

        // PUT: api/Materials_Objects/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterials_Objects(int id, Materials_Objects materials_Objects)
        {
            if (id != materials_Objects.ID_Materials_Objects)
            {
                return BadRequest();
            }

            _context.Entry(materials_Objects).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Materials_ObjectsExists(id))
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

        // POST: api/Materials_Objects
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Materials_Objects>> PostMaterials_Objects(Materials_Objects materials_Objects)
        {
            _context.Materials_Objects.Add(materials_Objects);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterials_Objects", new { id = materials_Objects.ID_Materials_Objects }, materials_Objects);
        }

        // DELETE: api/Materials_Objects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Materials_Objects>> DeleteMaterials_Objects(int id)
        {
            var materials_Objects = await _context.Materials_Objects.FindAsync(id);
            if (materials_Objects == null)
            {
                return NotFound();
            }

            _context.Materials_Objects.Remove(materials_Objects);
            await _context.SaveChangesAsync();

            return materials_Objects;
        }

        private bool Materials_ObjectsExists(int id)
        {
            return _context.Materials_Objects.Any(e => e.ID_Materials_Objects == id);
        }
    }
}
