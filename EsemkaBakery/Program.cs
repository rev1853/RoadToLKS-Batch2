using EsemkaBakery.Database;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.ExampleFilters();
});
builder.Services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());
builder.Services.AddDbContext<EsemkaBakeryContext>();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<EsemkaBakeryContext>();
    context.Database.EnsureDeleted();
    context.Database.Migrate();
    DbSeeder.SeedData(context);
}

app.Run();

namespace EsemkaBakery
{
    public class Converter
    {
        public static A? ConvertClass<A,B>(B? obj)
        {
            return JsonSerializer.Deserialize<A>(JsonSerializer.Serialize(obj));
        }
    }
}
