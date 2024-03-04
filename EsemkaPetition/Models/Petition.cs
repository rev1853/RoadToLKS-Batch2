using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EsemkaPetition.Models
{
    public class Petition
    {
        [Key]
        public int PetitionID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Target { get; set; }

        [ForeignKey("Creator")]
        public int CreatorID { get; set; }

        public User Creator { get; set; }
        public List<Signature> Signatures { get; set; } = new List<Signature>();
    }
}
