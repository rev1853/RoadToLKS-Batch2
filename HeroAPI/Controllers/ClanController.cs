﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeroAPI.Database;
using HeroAPI.DTOs.Response;
using HeroAPI.DTOs.Request;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClanController : ControllerBase
    {
        private readonly EsemkaHeroContext _context;

        public ClanController(EsemkaHeroContext context)
        {
            _context = context;
        }

        // GET: api/Clan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClanResponseDTO?>>> GetClans()
        {
            return await _context.Clans.Select(e => Converter.ConvertClass<ClanResponseDTO, Clan>(e)).ToListAsync();
        }

        // GET: api/Clan/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clan>> GetClan(int id)
        {
            var clan = await _context.Clans.FindAsync(id);

            if (clan == null)
            {
                return NotFound();
            }

            return clan;
        }

        // PUT: api/Clan/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClan(int id, ClanRequestDTO clan)
        {
            clan.Id = id;
            _context.Entry(clan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClanExists(id))
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

        // POST: api/Clan
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Clan>> PostClan(ClanRequestDTO clan)
        {
            clan.Id = 0;
            _context.Clans.Add(clan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClan", new { id = clan.Id }, clan);
        }

        // DELETE: api/Clan/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClan(int id)
        {
            var clan = await _context.Clans.FindAsync(id);
            if (clan == null)
            {
                return NotFound();
            }

            _context.Clans.Remove(clan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClanExists(int id)
        {
            return _context.Clans.Any(e => e.Id == id);
        }
    }
}
