using HeroAPI.Database;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HeroAPI.DTOs
{
    public class ClanDTO : Clan
    {
        [JsonIgnore]
        public new int Id { get => base.Id; set => base.Id = value; }

        [Required]
        [MaxLength(255)]
        public new string Name { get => base.Name; set => base.Name = value; }

        [JsonIgnore]
        public override ICollection<Hero> Heroes { get => base.Heroes; set => base.Heroes = value; }
    }
}
