using HeroAPI.Database;
using System.Text.Json.Serialization;

namespace HeroAPI.DTOs
{
    public class ElementDTO : Element
    {
        [JsonIgnore]
        public new int Id { get => base.Id; set => base.Id = value; }

        public string FirstSkill { get => base.Skills.First().Name; }

        [JsonIgnore]
        public override ICollection<Skill> Skills { get => base.Skills; set => base.Skills = value; }
    }
}
