using HeroAPI.Database;
using Newtonsoft.Json;

namespace HeroAPI.DTOs.Response
{
    public class ClanResponseDTO : Clan
    {
        public override ICollection<Hero> Heroes { set => base.Heroes = value; }
    }
}
