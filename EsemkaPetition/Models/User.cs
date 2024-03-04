using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EsemkaPetition.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Password { get; set; } = string.Empty;

        public List<Petition> CreatedPetitions { get; set; } = new List<Petition>();
        public List<Signature> SignedPetitions { get; set; } = new List<Signature>();
    }
}
