using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


public class Contexto : IdentityDbContext
{
    public DbSet<Ganancias> Ganancias { get; set; }
    public DbSet<Jugadas> Jugadas { get; set; }

    public DbSet<Loterias> Loterias { get; set; }

    public DbSet<TipoJugada> tipoJugada { get; set; }
    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }

        protected override void OnModelCreating(ModelBuilder model)
    {
          base.OnModelCreating(model);


        model.Entity<Loterias>().HasData
        (
            new Loterias
            {
                LoteriaId = 1,
                Nombre = "Loteka"
            },
            new Loterias
            {
                LoteriaId = 2,
                Nombre = "Loteria Real"
            },
            new Loterias
            {
                LoteriaId = 3,
                Nombre = "Loteria Nacional"
            },
            new Loterias
            {
                LoteriaId = 4,
                Nombre = "La Suerte"
            },
            new Loterias
            {
                LoteriaId = 5,
                Nombre = "La Gringa"
            },

            new Loterias
            {
                LoteriaId = 6,
                Nombre = "Leidsa",

            }

        );

        model.Entity<TipoJugada>().HasData
        (
            new TipoJugada
            {
                TipoJugadaId = 1,
                NombreJugada = "Quiniela Pale"
            },
             new TipoJugada
            {
                TipoJugadaId = 2,
                NombreJugada = "Super Kino"
            },
             new TipoJugada
            {
                TipoJugadaId = 3,
                NombreJugada = "Loto"
            },
             new TipoJugada
            {
                TipoJugadaId = 4,
                NombreJugada = "Loto Pool"
            },
            
             new TipoJugada
            {
                TipoJugadaId = 5,
                NombreJugada = "Quiniela"
            },
             new TipoJugada
            {
                TipoJugadaId = 6,
                NombreJugada = "Pega Mas"
            },
             new TipoJugada
            {
                TipoJugadaId = 7,
                NombreJugada = "Pale"
            },
        );

    }

}
