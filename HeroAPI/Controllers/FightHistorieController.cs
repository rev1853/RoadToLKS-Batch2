using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeroAPI.Database;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FightHistorieController : ControllerBase
    {
        private readonly EsemkaHeroContext _context;

        public FightHistorieController(EsemkaHeroContext context)
        {
            _context = context;
        }

        // GET: api/FightHistorie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FightHistory>>> GetFightHistories()
        {
            return await _context.FightHistories.ToListAsync();
        }

        // GET: api/FightHistorie/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FightHistory>> GetFightHistory(int id)
        {
            var fightHistory = await _context.FightHistories.FindAsync(id);

            if (fightHistory == null)
            {
                return NotFound();
            }

            return fightHistory;
        }

        // PUT: api/FightHistorie/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFightHistory(int id, FightHistory fightHistory)
        {
            if (id != fightHistory.Id)
            {
                return BadRequest();
            }

            _context.Entry(fightHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FightHistoryExists(id))
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

        // POST: api/FightHistorie
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FightHistory>> PostFightHistory(FightHistory fightHistory)
        {
            _context.FightHistories.Add(fightHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFightHistory", new { id = fightHistory.Id }, fightHistory);
        }

        // DELETE: api/FightHistorie/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFightHistory(int id)
        {
            var fightHistory = await _context.FightHistories.FindAsync(id);
            if (fightHistory == null)
            {
                return NotFound();
            }

            _context.FightHistories.Remove(fightHistory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FightHistoryExists(int id)
        {
            return _context.FightHistories.Any(e => e.Id == id);
        }
    }
}
