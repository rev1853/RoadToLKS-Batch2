using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EsemkaBakery.Database;
using EsemkaBakery.DTOs.Response;

namespace EsemkaBakery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakeController : ControllerBase
    {
        private readonly EsemkaBakeryContext _context;

        public CakeController(EsemkaBakeryContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Tags("Home Page", "Search Page")]
        public async Task<ActionResult<List<CakeResponseDTO?>>> All(string? search) 
        {
            var query = _context.Cakes.AsQueryable();
            if (search != default) query = query.Where(e => e.Name.Contains(search));

            return Ok(await query.Select(e => Converter.ConvertClass<CakeResponseDTO, Cake>(e)).ToListAsync());
        }

        [HttpGet("{id}")]
        [Tags("Home Page", "Detail Page")]
        public async Task<ActionResult<CakeResponseDTO?>> Find(int id)
        {
            var cake = await _context.Cakes.FindAsync(id);
            if (cake == default) return NotFound(new ErrorResponseDTO
            {
                Message = "Cake not found"
            });

            return Ok(Converter.ConvertClass<CakeDetailResponseDTO, Cake>(cake));
        }

    }
}
