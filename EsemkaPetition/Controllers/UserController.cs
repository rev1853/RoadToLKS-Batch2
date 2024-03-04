using EsemkaPetition.DTOs;
using EsemkaPetition.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EsemkaPetition.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(EsemkaPetitionContext context)
        {
            _context = context;
        }
        private readonly EsemkaPetitionContext _context;

        [Tags("06. Halaman Profile", "03. Halaman Home")]
        [HttpGet("/user/{id}")]
        public async Task<ActionResult<UserDTO>> FindUser(int id)
        {
            var user = await _context.Users.Select(e => new UserDTO
            {
                Email = e.Email,
                FirstName = e.FirstName,
                LastName = e.LastName,
                UserID = e.UserID
            }).FirstOrDefaultAsync(e => e.UserID == id);
            if (user == default) return NotFound("User not found");

            return Ok(user);
        }
    }
}
