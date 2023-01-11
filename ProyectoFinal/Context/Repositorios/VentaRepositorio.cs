using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Context.Repositorios
{
    public class VentaRepositorio
    {
        private readonly ApplicationDbContext _context;

        public VentaRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Venta>> ObtenerTodoAsync()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task<Venta> ObtenerPorIdAsync(int id)
        {
            return await _context.Ventas.FindAsync(id);
        }

        public async Task AgregarAsync(Venta venta)
        {
            await _context.Ventas.AddAsync(venta);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Venta venta)
        {
            _context.Ventas.Update(venta);
            await _context.SaveChangesAsync();
        }

        public async Task BorrarAsync(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);
            _context.Ventas.Remove(venta);
            await _context.SaveChangesAsync();
        }


    }
}
