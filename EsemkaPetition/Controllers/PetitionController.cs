using EsemkaPetition.DTOs;
using EsemkaPetition.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EsemkaPetition.Controllers
{
    [ApiController]
    public class PetitionController : ControllerBase
    {
        public PetitionController(EsemkaPetitionContext context)
        {
            _context = context;
        }
        private readonly EsemkaPetitionContext _context;

        [Tags("03. Halaman Home", "06. Halaman Profile")]
        [HttpGet("/petition")]
        public async Task<ActionResult<List<PetitionDTO>>> AllPetition([FromQuery] int? createdBy, [FromQuery] int? signedBy)
        {
            var query = _context.Petitions.AsQueryable();
            if (createdBy != default) query = query.Where(e => e.CreatorID == createdBy);
            if (signedBy != default) query = query.Where(e => e.Signatures.Any(f => f.SignerID == signedBy));
            
            var petitions = await query.Select(e => new PetitionDTO
            {
                Title = e.Title,
                PetitionID = e.PetitionID,
                CreatorName = $"{e.Creator.FirstName} {e.Creator.LastName}",
                Description = e.Description,
                Target = e.Target,
                TotalSigners = e.Signatures.Count
            }).ToListAsync();

            return Ok(petitions);
        }

        [Tags("04. Halaman Detail Petisi")]
        [HttpGet("/petition/{id}")]
        public async Task<ActionResult<PetitionDTO>> Petition(int id)
        {
            var petitions = await _context.Petitions.Select(e => new PetitionDTO
            {
                Title = e.Title,
                PetitionID = e.PetitionID,
                CreatorName = $"{e.Creator.FirstName} {e.Creator.FirstName}",
                Description = e.Description,
                Target = e.Target,
                TotalSigners = e.Signatures.Count
            }).FirstAsync(e => e.PetitionID == id);

            return Ok(petitions);
        }


        [Tags("04. Halaman Detail Petisi")]
        [HttpGet("/petition/{id}/is-signed")]
        public async Task<ActionResult<IsSignedDTO>> IsSigned(int id, [FromQuery] int signerID)
        {
            var petitions = await _context.Petitions.Where(e => e.PetitionID == id).Select(e => new IsSignedDTO
            {
                IsSigned = e.Signatures.Any(f => f.SignerID == signerID)
            }).FirstAsync();

            return Ok(petitions);
        }

        [Tags("04. Halaman Detail Petisi")]
        [HttpPost("/petition/{id}/sign")]
        public async Task<ActionResult<IsSignedDTO>> Sign(int id, [FromBody] SignPetitionDTO data)
        {
            var user = await _context.Users.FindAsync(data.SignerID);
            if (user == default) return BadRequest("Signer not valid user");

            var petition = await _context.Petitions.FindAsync(id);
            if (petition == default) return BadRequest("Petition not found");

            var signatureCount = await _context.Signatures.CountAsync(e => e.PetitionID == id && e.SignerID == data.SignerID);
            if (signatureCount > 0) return BadRequest("User has been already sign this petition");

            var signature = new Signature
            {
                PetitionID = id,
                SignerID = data.SignerID,
            };
            _context.Signatures.Add(signature);
            await _context.SaveChangesAsync();

            return Ok(new IsSignedDTO
            {
                IsSigned = true
            });
        }

        [Tags("05. Halaman Tambah Petisi")]
        [HttpPost("/petition")]
        public async Task<ActionResult<PetitionDTO>> NewPetition([FromBody] NewPetitionDTO data)
        {
            var petition = new Petition
            {
                CreatorID = data.CreatorID,
                Description = data.Description,
                Title = data.Title,
                Target = data.Target
            };
            _context.Petitions.Add(petition);
            var result = await _context.SaveChangesAsync();

            if (result > 0) return Created("", new PetitionDTO
            {
                Title = petition.Title,
                Description = petition.Description,
                PetitionID = petition.PetitionID,
                Target = petition.Target
            });
            else return BadRequest("Create new petition Failed");
        }
    }
}
