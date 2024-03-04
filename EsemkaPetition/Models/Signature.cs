using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EsemkaPetition.Models
{
    public class Signature
    {
        [Key]
        public int SignatureID { get; set; }

        [ForeignKey("Petition")]
        public int PetitionID { get; set; }

        [ForeignKey("Signer")]
        public int SignerID { get; set; }


        public Petition Petition { get; set; }
        public User Signer { get; set; }
    }
}
