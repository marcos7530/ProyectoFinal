//using ProyectoFinal.Context.Repositorio;
using ProyectoFinal.Context.Repositorios;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    public class TipoInmuebleServicio
    {

        private readonly TipoInmuebleRepositorio _repositorio;

        public TipoInmuebleServicio(TipoInmuebleRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<TipoInmueble>> GetAllAsync()
        {
            return await _repositorio.ObtenerTodoAsync();
        }

        public async Task<TipoInmueble> GetByIdAsync(int id)
        {
            return await _repositorio.ObtenerPorIdAsync(id);
        }

        public async Task AddAsync(TipoInmueble tipo)
        {
            await _repositorio.AgregarAsync(tipo);
        }

        public async Task UpdateAsync(TipoInmueble tipo)
        {
            await _repositorio.ActualizarAsync(tipo);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositorio.BorrarAsync(id);
        }

    }
}
