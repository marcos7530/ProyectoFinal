//using ProyectoFinal.Context.Repositorio;
using ProyectoFinal.Context.Repositorios;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    public class InmuebleServicio
    {
        private readonly InmuebleRepositorio _repositorio;

        public InmuebleServicio(InmuebleRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Inmueble>> GetAllAsync()
        {
            return await _repositorio.ObtenerTodoAsync();
        }

        public async Task<Inmueble> GetByIdAsync(int id)
        {
            return await _repositorio.ObtenerPorIdAsync(id);
        }

        public async Task AddAsync(Inmueble inmueble)
        {
            await _repositorio.AgregarAsync(inmueble);
        }

        public async Task UpdateAsync(Inmueble inmueble)
        {
            await _repositorio.ActualizarAsync(inmueble);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositorio.BorrarAsync(id);
        }


    }
}
