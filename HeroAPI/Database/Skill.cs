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


public static class SkillEndpoints
{
	public static void MapSkillEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Skill").WithTags(nameof(Skill));

        group.MapGet("/", async (EsemkaHeroContext db) =>
        {
            return await db.Skills.ToListAsync();
        })
        .WithName("GetAllSkills")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Skill>, NotFound>> (int id, EsemkaHeroContext db) =>
        {
            return await db.Skills.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Skill model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetSkillById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Skill skill, EsemkaHeroContext db) =>
        {
            var affected = await db.Skills
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.Id, skill.Id)
                  .SetProperty(m => m.Name, skill.Name)
                  .SetProperty(m => m.Description, skill.Description)
                  .SetProperty(m => m.ElementId, skill.ElementId)
                  .SetProperty(m => m.DifficultyLevel, skill.DifficultyLevel)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateSkill")
        .WithOpenApi();

        group.MapPost("/", async (Skill skill, EsemkaHeroContext db) =>
        {
            db.Skills.Add(skill);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Skill/{skill.Id}",skill);
        })
        .WithName("CreateSkill")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, EsemkaHeroContext db) =>
        {
            var affected = await db.Skills
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteSkill")
        .WithOpenApi();
    }
}