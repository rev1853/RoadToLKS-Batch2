using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeroAPI.Database;
using HeroAPI.DTOs;
using System.Text.Json;
using Newtonsoft.Json;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementController : ControllerBase
    {
        private readonly EsemkaHeroContext _context;

        public ElementController(EsemkaHeroContext context)
        {
            _context = context;
        }

        // GET: api/Element
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Element>>> GetElements()
        {
            return await _context.Elements.ToListAsync();
        }

        // GET: api/Element/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElementDTO>> GetElement(int id)
        {
            var element = await _context.Elements.Include(e => e.Skills).FirstAsync(e => e.Id == id);
            var el = JsonConvert.DeserializeObject<ElementDTO>(JsonConvert.SerializeObject(element));

            if (element == null)
            {
                return NotFound();
            }

            return Ok(el);
        }

        // PUT: api/Element/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElement(int id, ElementDTO element)
        {
            element.Id = id;
            _context.Entry(element).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(element);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElementExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        // POST: api/Element
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Element>> PostElement(ElementDTO element)
        {
            element.Id = 0;
            _context.Elements.Add(element);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElement", new { id = element.Id }, element);
        }

        // DELETE: api/Element/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElement(int id)
        {
            var element = await _context.Elements.FindAsync(id);
            if (element == null)
            {
                return NotFound();
            }

            _context.Elements.Remove(element);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElementExists(int id)
        {
            return _context.Elements.Any(e => e.Id == id);
        }
    }
}
