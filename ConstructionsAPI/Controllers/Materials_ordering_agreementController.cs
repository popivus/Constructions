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
    public class Materials_ordering_agreementController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public Materials_ordering_agreementController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Materials_ordering_agreement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materials_ordering_agreement>>> GetMaterials_ordering_agreement()
        {
            return await _context.Materials_ordering_agreement.ToListAsync();
        }

        // GET: api/Materials_ordering_agreement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materials_ordering_agreement>> GetMaterials_ordering_agreement(int id)
        {
            var materials_ordering_agreement = await _context.Materials_ordering_agreement.FindAsync(id);

            if (materials_ordering_agreement == null)
            {
                return NotFound();
            }

            return materials_ordering_agreement;
        }

        [HttpGet("search/{id}")]
        public async Task<ActionResult<List<Materials_ordering_agreement>>> GetMaterials_ordering_agreement(string id)
        {
            var materials_ordering_agreement = await _context.Materials_ordering_agreement.Where(m => m.ID_Materials_ordering_agreement.ToString().Contains(id)).ToListAsync();

            if (materials_ordering_agreement == null)
            {
                return NotFound();
            }

            return materials_ordering_agreement;
        }

        // PUT: api/Materials_ordering_agreement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterials_ordering_agreement(int id, Materials_ordering_agreement materials_ordering_agreement)
        {
            if (id != materials_ordering_agreement.ID_Materials_ordering_agreement)
            {
                return BadRequest();
            }

            _context.Entry(materials_ordering_agreement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Materials_ordering_agreementExists(id))
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

        // POST: api/Materials_ordering_agreement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Materials_ordering_agreement>> PostMaterials_ordering_agreement(Materials_ordering_agreement materials_ordering_agreement)
        {
            _context.Materials_ordering_agreement.Add(materials_ordering_agreement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterials_ordering_agreement", new { id = materials_ordering_agreement.ID_Materials_ordering_agreement }, materials_ordering_agreement);
        }

        // DELETE: api/Materials_ordering_agreement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Materials_ordering_agreement>> DeleteMaterials_ordering_agreement(int id)
        {
            var materials_ordering_agreement = await _context.Materials_ordering_agreement.FindAsync(id);
            if (materials_ordering_agreement == null)
            {
                return NotFound();
            }

            _context.Materials_ordering_agreement.Remove(materials_ordering_agreement);
            await _context.SaveChangesAsync();

            return materials_ordering_agreement;
        }

        private bool Materials_ordering_agreementExists(int id)
        {
            return _context.Materials_ordering_agreement.Any(e => e.ID_Materials_ordering_agreement == id);
        }
    }
}
