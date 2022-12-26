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
    public class CounterpartiesController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public CounterpartiesController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Counterparties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Counterparty>>> GetCounterparty()
        {
            return await _context.Counterparty.ToListAsync();
        }

        // GET: api/Counterparties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Counterparty>> GetCounterparty(int id)
        {
            var counterparty = await _context.Counterparty.FindAsync(id);

            if (counterparty == null)
            {
                return NotFound();
            }

            return counterparty;
        }

        [HttpGet("search/{id}")]
        public async Task<ActionResult<List<Counterparty>>> GetCounterparty(string id)
        {
            var counterparty = await _context.Counterparty.Where(m => m.Name.Contains(id)).ToListAsync();

            if (counterparty == null)
            {
                return NotFound();
            }

            return counterparty;
        }

        // PUT: api/Counterparties/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCounterparty(int id, Counterparty counterparty)
        {
            if (id != counterparty.ID_Counterparty)
            {
                return BadRequest();
            }

            _context.Entry(counterparty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CounterpartyExists(id))
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

        // POST: api/Counterparties
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Counterparty>> PostCounterparty(Counterparty counterparty)
        {
            _context.Counterparty.Add(counterparty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCounterparty", new { id = counterparty.ID_Counterparty }, counterparty);
        }

        // DELETE: api/Counterparties/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Counterparty>> DeleteCounterparty(int id)
        {
            var counterparty = await _context.Counterparty.FindAsync(id);
            if (counterparty == null)
            {
                return NotFound();
            }

            _context.Counterparty.Remove(counterparty);
            await _context.SaveChangesAsync();

            return counterparty;
        }

        private bool CounterpartyExists(int id)
        {
            return _context.Counterparty.Any(e => e.ID_Counterparty == id);
        }
    }
}
