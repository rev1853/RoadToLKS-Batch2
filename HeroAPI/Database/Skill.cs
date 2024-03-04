﻿using System;
using System.Collections.Generic;

namespace HeroAPI.Database;

public partial class Skill
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int ElementId { get; set; }

    public string DifficultyLevel { get; set; } = null!;

    public virtual Element Element { get; set; } = null!;

    public virtual ICollection<HeroSkill> HeroSkills { get; set; } = new List<HeroSkill>();
}
