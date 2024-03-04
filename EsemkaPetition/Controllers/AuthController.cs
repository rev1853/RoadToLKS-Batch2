using EsemkaPetition.DTOs;
using EsemkaPetition.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EsemkaPetition.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {

        public AuthController(EsemkaPetitionContext context)
        {
            _context = context;
        }

        private readonly EsemkaPetitionContext _context;

        [Tags("01. Halaman Sign In")]
        [HttpPost("/sign-in")]
        public async Task<ActionResult<UserDTO>> SignIn([FromBody] SignInDTO data)
        {
            var user = await _context.Users.Where(e => e.Email == data.Email && e.Password == data.Password)
                .Select(e => new UserDTO
                {
                    Email = e.Email,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    UserID = e.UserID
                }).FirstOrDefaultAsync();
            if (user == null) return Unauthorized("Sign In failed");
            return Ok(user);
        }

        [Tags("02. Halaman Sign UP")]
        [HttpPost("/sign-up")]
        public async Task<ActionResult<UserDTO>> SignUp([FromBody] SignUpDTO data)
        {
            var emailCount = await _context.Users.CountAsync(e => e.Email == data.Email);
            if (emailCount > 0) return BadRequest("Email has been already used");

            var user = new User
            {
                Email = data.Email,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Password = data.Password
            };
            _context.Users.Add(user);
            var result = await _context.SaveChangesAsync();

            if (result > 0) return Created("", new UserDTO
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserID = user.UserID
            });
            else return BadRequest("Sign Up Failed");
        }
    }
}
