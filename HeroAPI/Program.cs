using HeroAPI.Database;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

JsonConvert.DefaultSettings = () => new JsonSerializerSettings
{
    Formatting = Formatting.Indented,
    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
};

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EsemkaHeroContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();

namespace HeroAPI
{
    public class Converter
    {
        public static A? ConvertClass<A, B>(B? obj)
        {
            return JsonConvert.DeserializeObject<A>(JsonConvert.SerializeObject(obj));
        }
    }
}