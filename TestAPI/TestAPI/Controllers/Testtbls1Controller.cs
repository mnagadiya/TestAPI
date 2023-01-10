using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;
using TestAPI.Models.Domain;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Testtbls1Controller : ControllerBase
    {
        private readonly TestdbContext _context;

        public Testtbls1Controller(TestdbContext context)
        {
            _context = context;
        }

        // GET: api/Testtbls1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Testtbl>>> GetTesttbls()
        {
          if (_context.Testtbls == null)
          {
              return NotFound();
          }
            return await _context.Testtbls.ToListAsync();
        }

        // GET: api/Testtbls1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Testtbl>> GetTesttbl(int id)
        {
          if (_context.Testtbls == null)
          {
              return NotFound();
          }
            var testtbl = await _context.Testtbls.FindAsync(id);

            if (testtbl == null)
            {
                return NotFound();
            }

            return testtbl;
        }

        // PUT: api/Testtbls1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTesttbl(int id, Testtbl testtbl)
        {
            if (id != testtbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(testtbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TesttblExists(id))
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

        // POST: api/Testtbls1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Testtbl>> PostTesttbl(Testtbl testtbl)
        {
          if (_context.Testtbls == null)
          {
              return Problem("Entity set 'TestdbContext.Testtbls'  is null.");
          }
            _context.Testtbls.Add(testtbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTesttbl", new { id = testtbl.Id }, testtbl);
        }

        // DELETE: api/Testtbls1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTesttbl(int id)
        {
            if (_context.Testtbls == null)
            {
                return NotFound();
            }
            var testtbl = await _context.Testtbls.FindAsync(id);
            if (testtbl == null)
            {
                return NotFound();
            }

            _context.Testtbls.Remove(testtbl);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TesttblExists(int id)
        {
            return (_context.Testtbls?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
