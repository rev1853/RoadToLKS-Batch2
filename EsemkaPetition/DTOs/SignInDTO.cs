using System.ComponentModel.DataAnnotations;

namespace EsemkaPetition.DTOs
{
    public class SignInDTO
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
