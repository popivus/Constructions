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
    public class Equipment_order_agreementController : ControllerBase
    {
        private readonly ConstructionsDBContext _context;

        public Equipment_order_agreementController(ConstructionsDBContext context)
        {
            _context = context;
        }

        // GET: api/Equipment_order_agreement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment_order_agreement>>> GetEquipment_order_agreement()
        {
            return await _context.Equipment_order_agreement.ToListAsync();
        }

        // GET: api/Equipment_order_agreement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipment_order_agreement>> GetEquipment_order_agreement(int id)
        {
            var equipment_order_agreement = await _context.Equipment_order_agreement.FindAsync(id);

            if (equipment_order_agreement == null)
            {
                return NotFound();
            }

            return equipment_order_agreement;
        }

        [HttpGet("search/{id}")]
        public async Task<ActionResult<List<Equipment_order_agreement>>> GetEquipment_order_agreement(string id)
        {
            var equipment_order_agreement = await _context.Equipment_order_agreement.Where(m => m.ID_Equipment_order_agreement.ToString().Contains(id)).ToListAsync();

            if (equipment_order_agreement == null)
            {
                return NotFound();
            }

            return equipment_order_agreement;
        }


        // PUT: api/Equipment_order_agreement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipment_order_agreement(int id, Equipment_order_agreement equipment_order_agreement)
        {
            if (id != equipment_order_agreement.ID_Equipment_order_agreement)
            {
                return BadRequest();
            }

            _context.Entry(equipment_order_agreement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Equipment_order_agreementExists(id))
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

        // POST: api/Equipment_order_agreement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Equipment_order_agreement>> PostEquipment_order_agreement(Equipment_order_agreement equipment_order_agreement)
        {
            _context.Equipment_order_agreement.Add(equipment_order_agreement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipment_order_agreement", new { id = equipment_order_agreement.ID_Equipment_order_agreement }, equipment_order_agreement);
        }

        // DELETE: api/Equipment_order_agreement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Equipment_order_agreement>> DeleteEquipment_order_agreement(int id)
        {
            var equipment_order_agreement = await _context.Equipment_order_agreement.FindAsync(id);
            if (equipment_order_agreement == null)
            {
                return NotFound();
            }

            _context.Equipment_order_agreement.Remove(equipment_order_agreement);
            await _context.SaveChangesAsync();

            return equipment_order_agreement;
        }

        private bool Equipment_order_agreementExists(int id)
        {
            return _context.Equipment_order_agreement.Any(e => e.ID_Equipment_order_agreement == id);
        }
    }
}
