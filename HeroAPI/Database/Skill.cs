using System;
using System.Collections.Generic;
using HeroAPI.Database;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

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