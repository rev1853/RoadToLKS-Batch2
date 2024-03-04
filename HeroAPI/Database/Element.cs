﻿using System;
using System.Collections.Generic;

namespace HeroAPI.Database;

public partial class Element
{
    public int Id { get; set; }

    public string Element1 { get; set; } = null!;

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}