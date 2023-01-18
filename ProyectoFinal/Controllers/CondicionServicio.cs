//using ProyectoFinal.Context.Repositorio;
using ProyectoFinal.Context.Repositorios;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    public class CondicionServicio
    {

        private readonly CondicionRepositorio _repositorio;

        public CondicionServicio(CondicionRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Condicion>> GetAllAsync()
        {
            return await _repositorio.ObtenerTodoAsync();
        }

        public async Task<Condicion> GetByIdAsync(int id)
        {
            return await _repositorio.ObtenerPorIdAsync(id);
        }

        public async Task AddAsync(Condicion formaPago)
        {
            await _repositorio.AgregarAsync(formaPago);
        }

        public async Task UpdateAsync(Condicion formaPago)
        {
            await _repositorio.ActualizarAsync(formaPago);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositorio.BorrarAsync(id);
        }





    }
}
