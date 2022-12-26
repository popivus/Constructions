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
    public class Sales_contractController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public Sales_contractController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Sales_contract
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sales_contract>>> GetSales_contract()
        {
            return await _context.Sales_contract.ToListAsync();
        }

        // GET: api/Sales_contract/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sales_contract>> GetSales_contract(int id)
        {
            var sales_contract = await _context.Sales_contract.FindAsync(id);

            if (sales_contract == null)
            {
                return NotFound();
            }

            return sales_contract;
        }

        [HttpGet("search/{id}")]
        public async Task<ActionResult<IEnumerable<Sales_contract>>> GetSales_contract(string id)
        {
            var sales_contract = await _context.Sales_contract.Where(t => t.Number.Contains(id)).ToListAsync();

            if (sales_contract == null)
            {
                return NotFound();
            }

            return sales_contract;
        }

        // PUT: api/Sales_contract/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSales_contract(int id, Sales_contract sales_contract)
        {
            if (id != sales_contract.ID_Sales_contract)
            {
                return BadRequest();
            }

            _context.Entry(sales_contract).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Sales_contractExists(id))
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

        // POST: api/Sales_contract
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Sales_contract>> PostSales_contract(Sales_contract sales_contract)
        {
            _context.Sales_contract.Add(sales_contract);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSales_contract", new { id = sales_contract.ID_Sales_contract }, sales_contract);
        }

        // DELETE: api/Sales_contract/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sales_contract>> DeleteSales_contract(int id)
        {
            var sales_contract = await _context.Sales_contract.FindAsync(id);
            if (sales_contract == null)
            {
                return NotFound();
            }

            _context.Sales_contract.Remove(sales_contract);
            await _context.SaveChangesAsync();

            return sales_contract;
        }

        private bool Sales_contractExists(int id)
        {
            return _context.Sales_contract.Any(e => e.ID_Sales_contract == id);
        }
    }
}
