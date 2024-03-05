using HeroAPI.Database;

namespace HeroAPI.DTOs.Response
{
    public class ElementResponseDTO : Element
    {
        public override ICollection<Skill> Skills { set => base.Skills = value; }
    }
}
