using HeroAPI.Database;
using System.Text.Json.Serialization;

namespace HeroAPI.DTOs.Request
{
    public class ClanRequestDTO : Clan
    {
        [JsonIgnore]
        public new int Id { get => base.Id; set => base.Id = value; }
        [JsonIgnore]
        public override ICollection<Hero> Heroes { get => base.Heroes; set => base.Heroes = value; }
    }
}
