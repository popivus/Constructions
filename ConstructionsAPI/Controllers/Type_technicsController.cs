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
    public class Type_technicsController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public Type_technicsController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Type_technics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Type_technics>>> GetType_technics()
        {
            return await _context.Type_technics.ToListAsync();
        }

        // GET: api/Type_technics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Type_technics>> GetType_technics(int id)
        {
            var type_technics = await _context.Type_technics.FindAsync(id);

            if (type_technics == null)
            {
                return NotFound();
            }

            return type_technics;
        }

        // PUT: api/Type_technics/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutType_technics(int id, Type_technics type_technics)
        {
            if (id != type_technics.ID_Type_technics)
            {
                return BadRequest();
            }

            _context.Entry(type_technics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Type_technicsExists(id))
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

        // POST: api/Type_technics
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Type_technics>> PostType_technics(Type_technics type_technics)
        {
            _context.Type_technics.Add(type_technics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetType_technics", new { id = type_technics.ID_Type_technics }, type_technics);
        }

        // DELETE: api/Type_technics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Type_technics>> DeleteType_technics(int id)
        {
            var type_technics = await _context.Type_technics.FindAsync(id);
            if (type_technics == null)
            {
                return NotFound();
            }

            _context.Type_technics.Remove(type_technics);
            await _context.SaveChangesAsync();

            return type_technics;
        }

        private bool Type_technicsExists(int id)
        {
            return _context.Type_technics.Any(e => e.ID_Type_technics == id);
        }
    }
}
