using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Condicion> Condiciones { get; set; }

        public DbSet<FormaPago> FormasPagos { get; set; }

        public DbSet<Inmueble> Inmuebles { get; set; }

        public DbSet<TipoInmueble> TiposInmuebles { get; set; }

        public DbSet<Venta> Ventas { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

    }
}
