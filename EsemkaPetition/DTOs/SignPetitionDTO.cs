using System.ComponentModel.DataAnnotations;

namespace EsemkaPetition.DTOs
{
    public class SignPetitionDTO
    {
        [Required]
        public int SignerID { get; set; }
    }
}
