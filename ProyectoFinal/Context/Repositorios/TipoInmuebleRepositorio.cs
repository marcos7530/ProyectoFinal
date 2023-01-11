using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Context.Repositorios
{
    public class TipoInmuebleRepositorio
    {

        private readonly ApplicationDbContext _context;

        public TipoInmuebleRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TipoInmueble>> ObtenerTodoAsync()
        {
            return await _context.TiposInmuebles.ToListAsync();
        }

        public async Task<TipoInmueble> ObtenerPorIdAsync(int id)
        {
            return await _context.TiposInmuebles.FindAsync(id);
        }

        public async Task AgregarAsync(TipoInmueble tipo)
        {
            await _context.TiposInmuebles.AddAsync(tipo);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(TipoInmueble tipo)
        {
            _context.TiposInmuebles.Update(tipo);
            await _context.SaveChangesAsync();
        }

        public async Task BorrarAsync(int id)
        {
            var tipo = await _context.TiposInmuebles.FindAsync(id);
            _context.TiposInmuebles.Remove(tipo);
            await _context.SaveChangesAsync();
        }


    }
}
