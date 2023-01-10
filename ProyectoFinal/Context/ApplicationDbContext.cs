using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CLIENTE> Clientes { get; set; }

        public DbSet<CONDICION> Condiciones { get; set; }

        public DbSet<FORMA_PAGO> FormasPagos { get; set; }

        public DbSet<INMUEBLE> Inmuebles { get; set; }

        public DbSet<TIPO_INMUEBLE> TiposInmuebles { get; set; }

        public DbSet<VENTA> Ventas { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

    }
}
