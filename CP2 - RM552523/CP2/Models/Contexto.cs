using Microsoft.EntityFrameworkCore;
using CP2.Models;

namespace CP2.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> option): base(option)
        {
        }

        public DbSet<Postagem> Postagem { get; set; }
        public DbSet<CP2.Models.Blog> Blog { get; set; } = default!;
    }
}
