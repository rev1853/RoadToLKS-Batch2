using HeroAPI.Database;
using System.Text.Json.Serialization;

namespace HeroAPI.DTOs
{
    public class HeroDTO : Hero
    {
        [JsonIgnore]
        public override Clan? Clan { get => base.Clan; set => base.Clan = value; }
        [JsonIgnore]
        public override ICollection<HeroSkill> HeroSkills { get => base.HeroSkills; set => base.HeroSkills = value; }
        public new DateTime BirthDate { get => base.BirthDate.ToDateTime(TimeOnly.MinValue); set => base.BirthDate = DateOnly.FromDateTime(value); }
        public string BirthDateFormatted { get => BirthDate.ToString("dd MMMM yyyy"); }
        public string? ClanName { get => base.Clan?.Name; }
    }
}
