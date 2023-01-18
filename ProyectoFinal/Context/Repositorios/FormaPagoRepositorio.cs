using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Context.Repositorios
{
    public class FormaPagoRepositorio
    {
        private readonly ApplicationDbContext _context;

        public FormaPagoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<FormaPago>> ObtenerTodoAsync()
        {
            return await _context.FormasPagos.ToListAsync();
        }

        public async Task<FormaPago> ObtenerPorIdAsync(int id)
        {
            return await _context.FormasPagos.FindAsync(id);
        }

        public async Task AgregarAsync(FormaPago formaPago)
        {
            await _context.FormasPagos.AddAsync(formaPago);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(FormaPago formaPago)
        {
            _context.FormasPagos.Update(formaPago);
            await _context.SaveChangesAsync();
        }

        public async Task BorrarAsync(int id)
        {
            var formaPago = await _context.FormasPagos.FindAsync(id);
            _context.FormasPagos.Remove(formaPago);
            await _context.SaveChangesAsync();
        }


    }
}
