
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
    public class ObjectsController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public ObjectsController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Objects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Object>>> GetObject()
        {
            return await _context.Object.ToListAsync();
        }

        // GET: api/Objects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Object>> GetObject(int id)
        {
            var @object = await _context.Object.FindAsync(id);

            if (@object == null)
            {
                return NotFound();
            }

            return @object;
        }

        [HttpGet("search/{id}")]
        public async Task<ActionResult<List<Object>>> GetObject(string id)
        {
            var objects = await _context.Object.Where(m => m.ID_Object.ToString().Contains(id)).ToListAsync();

            if (objects == null)
            {
                return NotFound();
            }

            return objects;
        }

        // PUT: api/Objects/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObject(int id, Object @object)
        {
            if (id != @object.ID_Object)
            {
                return BadRequest();
            }

            _context.Entry(@object).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjectExists(id))
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

        // POST: api/Objects
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Object>> PostObject(Object @object)
        {
            _context.Object.Add(@object);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObject", new { id = @object.ID_Object }, @object);
        }

        // DELETE: api/Objects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Object>> DeleteObject(int id)
        {
            var @object = await _context.Object.FindAsync(id);
            if (@object == null)
            {
                return NotFound();
            }

            _context.Object.Remove(@object);
            await _context.SaveChangesAsync();

            return @object;
        }

        private bool ObjectExists(int id)
        {
            return _context.Object.Any(e => e.ID_Object == id);
        }
    }
}
