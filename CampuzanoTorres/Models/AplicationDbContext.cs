using Microsoft.EntityFrameworkCore;
namespace CampuzanoTorres.Models
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Genero> Genero { get; set; }



    }
}
