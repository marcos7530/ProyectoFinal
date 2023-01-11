using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Context.Repositorios
{
    public class InmuebleRepositorio
    {

        private readonly ApplicationDbContext _context;

        public InmuebleRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Inmueble>> ObtenerTodoAsync()
        {
            return await _context.Inmuebles.ToListAsync();
        }

        public async Task<Inmueble> ObtenerPorIdAsync(int id)
        {
            return await _context.Inmuebles.FindAsync(id);
        }

        public async Task AgregarAsync(Inmueble inmueble)
        {
            await _context.Inmuebles.AddAsync(inmueble);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Inmueble inmueble)
        {
            _context.Inmuebles.Update(inmueble);
            await _context.SaveChangesAsync();
        }

        public async Task BorrarAsync(int id)
        {
            var inmueble = await _context.Inmuebles.FindAsync(id);
            _context.Inmuebles.Remove(inmueble);
            await _context.SaveChangesAsync();
        }


    }
}
