using System;
using System.Collections.Generic;

namespace HeroAPI.Database;

public partial class Hero
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateOnly BirthDate { get; set; }

    public int? ClanId { get; set; }

    public virtual Clan? Clan { get; set; }

    public virtual ICollection<HeroSkill> HeroSkills { get; set; } = new List<HeroSkill>();
}
