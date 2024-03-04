using Microsoft.EntityFrameworkCore;

namespace EsemkaPetition.Models
{
    public class EsemkaPetitionContext : DbContext
    {
        public EsemkaPetitionContext(DbContextOptions<EsemkaPetitionContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        private readonly IConfiguration _configuration;

        public DbSet<User> Users { get; set; }
        public DbSet<Petition> Petitions { get; set; }
        public DbSet<Signature> Signatures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
