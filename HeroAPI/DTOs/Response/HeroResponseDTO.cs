using HeroAPI.Database;
using Newtonsoft.Json;

namespace HeroAPI.DTOs.Response
{
    public class HeroResponseDTO : Hero
    {
        public new int? ClanId { set => base.ClanId = value;  }
        public new ClanResponseDTO? Clan { get => Converter.ConvertClass<ClanResponseDTO, Clan>(base.Clan); set => base.Clan = value; }
        public override ICollection<HeroSkill> HeroSkills { set => base.HeroSkills = value; }
    }
}
