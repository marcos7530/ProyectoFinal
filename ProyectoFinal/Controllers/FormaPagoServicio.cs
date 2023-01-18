using ProyectoFinal.Context.Repositorios;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    public class FormaPagoServicio
    {

        private readonly FormaPagoRepositorio _repositorio;

        public FormaPagoServicio(FormaPagoRepositorio repositorio)
        {
            _repositorio=repositorio;
        }

        public async Task<List<FormaPago>> GetAllAsync()
        {
            return await _repositorio.ObtenerTodoAsync();
        }

        public async Task<FormaPago> GetByIdAsync(int id)
        {
            return await _repositorio.ObtenerPorIdAsync(id);
        }

        public async Task AddAsync(FormaPago formaPago)
        { 
        await _repositorio.AgregarAsync(formaPago);
        }

        public async Task UpdateAsync(FormaPago formaPago)
        { 
        await _repositorio.ActualizarAsync(formaPago);
        }

        public async Task DeleteAsync(int id)
        { 
        await _repositorio.BorrarAsync(id);
        }


    }
}
