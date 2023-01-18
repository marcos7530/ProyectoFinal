//using ProyectoFinal.Context.Repositorio;
using ProyectoFinal.Context.Repositorios;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    public class VentaServicio
    {
        private readonly VentaRepositorio _repositorio;

        public VentaServicio(VentaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Venta>> GetAllAsync()
        {
            return await _repositorio.ObtenerTodoAsync();
        }

        public async Task<Venta> GetByIdAsync(int id)
        {
            return await _repositorio.ObtenerPorIdAsync(id);
        }

        public async Task AddAsync(Venta venta)
        {
            await _repositorio.AgregarAsync(venta);
        }

        public async Task UpdateAsync(Venta venta)
        {
            await _repositorio.ActualizarAsync(venta);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositorio.BorrarAsync(id);
        }
    }
}
