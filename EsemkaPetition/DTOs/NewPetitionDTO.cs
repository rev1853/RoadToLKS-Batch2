using System.ComponentModel.DataAnnotations;

namespace EsemkaPetition.DTOs
{
    public class NewPetitionDTO
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1, int.MaxValue)]
        public int Target { get; set; }

        [Required]
        public int CreatorID { get; set; }
    }
}
