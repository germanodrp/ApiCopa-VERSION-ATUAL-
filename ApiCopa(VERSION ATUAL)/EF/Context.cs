using ApiCopa_VERSION_ATUAL_.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiCopa_VERSION_ATUAL_.EF
{
    public class Context:DbContext
    {
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Confederacoes> Confederacoes { get; set; }
        public DbSet<Potes> Potes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer("Data source = 201.62.57.93 ;Database = BD040160; User Id= RA040160;Password = 040160;");
        }
    }
}
