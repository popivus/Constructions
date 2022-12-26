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
    public class Type_objectController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public Type_objectController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Type_object
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Type_object>>> GetType_object()
        {
            return await _context.Type_object.ToListAsync();
        }

        // GET: api/Type_object/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Type_object>> GetType_object(int id)
        {
            var type_object = await _context.Type_object.FindAsync(id);

            if (type_object == null)
            {
                return NotFound();
            }

            return type_object;
        }

        // PUT: api/Type_object/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutType_object(int id, Type_object type_object)
        {
            if (id != type_object.ID_Type_object)
            {
                return BadRequest();
            }

            _context.Entry(type_object).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Type_objectExists(id))
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

        // POST: api/Type_object
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Type_object>> PostType_object(Type_object type_object)
        {
            _context.Type_object.Add(type_object);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetType_object", new { id = type_object.ID_Type_object }, type_object);
        }

        // DELETE: api/Type_object/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Type_object>> DeleteType_object(int id)
        {
            var type_object = await _context.Type_object.FindAsync(id);
            if (type_object == null)
            {
                return NotFound();
            }

            _context.Type_object.Remove(type_object);
            await _context.SaveChangesAsync();

            return type_object;
        }

        private bool Type_objectExists(int id)
        {
            return _context.Type_object.Any(e => e.ID_Type_object == id);
        }
    }
}
