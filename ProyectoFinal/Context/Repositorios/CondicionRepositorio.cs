using Microsoft.EntityFrameworkCore;
//using ProyectoFinal.Context.Repositorio;
using ProyectoFinal.Controllers;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Context.Repositorios
{
    public class CondicionRepositorio
    {

        private readonly ApplicationDbContext _context;

        public CondicionRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Condicion>> ObtenerTodoAsync()
        {
            return await _context.Condiciones.ToListAsync();
        }

        public async Task<Condicion> ObtenerPorIdAsync(int id)
        {
            return await _context.Condiciones.FindAsync(id);
        }

        public async Task AgregarAsync(Condicion condicion)
        {
            await _context.Condiciones.AddAsync(condicion);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Condicion condicion)
        {
            _context.Condiciones.Update(condicion);
            await _context.SaveChangesAsync();
        }

        public async Task BorrarAsync(int id)
        {
            var condicion = await _context.Condiciones.FindAsync(id);
            _context.Condiciones.Remove(condicion);
            await _context.SaveChangesAsync();
        }


    }
}
