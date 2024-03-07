using EsemkaBakery.Database;
using EsemkaBakery.DTOs.Request;
using EsemkaBakery.DTOs.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EsemkaBakery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(EsemkaBakeryContext context) : ControllerBase
    {
        EsemkaBakeryContext _context = context;

        [HttpPost("Login")]
        [ProducesResponseType(typeof(ErrorResponseDTO), 401)]
        [Tags("Login Page")]
        public async Task<ActionResult<UserResponseDTO>> Login(LoginRequestDTO data)
        {
            var user = await _context.Users
                .Where(e => (e.Email == data.UsernameOrEmail || e.Username == data.UsernameOrEmail) && e.Password == data.Password)
                .FirstOrDefaultAsync();

            if (user == default) return Unauthorized(new ErrorResponseDTO { Message = "Credential not found" });
            return Ok(Converter.ConvertClass<UserResponseDTO, User>(user));
        }

        [HttpPost("Register")]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        [Tags("Register Page")]
        public async Task<ActionResult<UserResponseDTO>> Register(RegisterRequestDTO data)
        {
            data.UserID = 0;

            if (_context.Users.Any(e => e.Email == data.Email || e.Username == data.Username)) return BadRequest(new ErrorResponseDTO
            {
                Message = "Email or Username has been already used"
            });

            if (data.Password != data.PasswordConfirmation) return BadRequest(new ErrorResponseDTO
            {
                Message = "Password confirmation failed"
            });

            _context.Users.Add(data);
            await _context.SaveChangesAsync();

            return Ok(Converter.ConvertClass<UserResponseDTO, User>(data));
        }
    }
}
