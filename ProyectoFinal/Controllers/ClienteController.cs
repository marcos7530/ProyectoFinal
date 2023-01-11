using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ClienteServicio _servicio;

        public ClienteController(ClienteServicio servicio)
        {
            _servicio = servicio;
        }


        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> GetAllAsync()
        {

            var clientes = await _servicio.GetAllAsync();
            return Ok(clientes);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetByIdAsync(int id)
        {
            var cliente = await _servicio.GetByIdAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> AddAsync(Cliente cliente)
        {

            await _servicio.AddAsync(cliente);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = cliente.ClienteId }, cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, Cliente cliente)
        {
            if (id != cliente.ClienteId)
            {
                return BadRequest();
            }

            await _servicio.UpdateAsync(cliente);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _servicio.DeleteAsync(id);
            return NoContent();
        }

    }
}
