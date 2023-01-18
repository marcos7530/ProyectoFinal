//using ProyectoFinal.Context.Repositorio;
using ProyectoFinal.Context.Repositorios;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    public class ClienteServicio
    {
        private readonly ClienteRepositorio _repositorio;

        public ClienteServicio(ClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Cliente>> GetAllAsync()
        {
            return await _repositorio.ObtenerTodoAsync();
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            return await _repositorio.ObtenerPorIdAsync(id);
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _repositorio.AgregarAsync(cliente);
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            await _repositorio.ActualizarAsync(cliente);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositorio.BorrarAsync(id);
        }
    }
}
