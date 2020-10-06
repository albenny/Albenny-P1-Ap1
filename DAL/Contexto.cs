using Albenny_P1_AP1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Albenny_P1_AP1.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Ciudades> Ciudades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA \ Base De Datos.db");
        }

    }
}
