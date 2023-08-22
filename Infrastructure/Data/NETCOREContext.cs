using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data;


public class NETCOREContext : DbContext 
{

    public NETCOREContext(DbContextOptions<NETCOREContext> options) : base(options)
    {

    }

    public DbSet<Pais> Paises { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Region> Regiones { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<ProductoPersona> ProductoPersonas { get; set; }
}