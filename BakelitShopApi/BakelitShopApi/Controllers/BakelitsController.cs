using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BakelitShopApi.Data;
using BakelitShopApi.Models;

namespace BakelitShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BakelitsController : ControllerBase
    {
        private readonly BakelitShopApiContext _context;

        public BakelitsController(BakelitShopApiContext context)
        {
            _context = context;
        }

        // GET: api/Bakelits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bakelit>>> GetBakelits()
        {
            return await _context.Bakelits.ToListAsync();
        }

        // GET: api/Bakelits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bakelit>> GetBakelits(int id)
        {
            var bakelits = await _context.Bakelits.FindAsync(id);

            if (bakelits == null)
            {
                return NotFound();
            }

            return bakelits;
        }

        // PUT: api/Bakelits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBakelits(int id, Bakelit bakelits)
        {
            if (id != bakelits.Id)
            {
                return BadRequest();
            }

            _context.Entry(bakelits).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BakelitsExists(id))
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

        // POST: api/Bakelits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bakelit>> PostBakelits(Bakelit bakelits)
        {
            _context.Bakelits.Add(bakelits);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBakelits", new { id = bakelits.Id }, bakelits);
        }

        // DELETE: api/Bakelits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBakelits(int id)
        {
            var bakelits = await _context.Bakelits.FindAsync(id);
            if (bakelits == null)
            {
                return NotFound();
            }

            _context.Bakelits.Remove(bakelits);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BakelitsExists(int id)
        {
            return _context.Bakelits.Any(e => e.Id == id);
        }
    }
}
