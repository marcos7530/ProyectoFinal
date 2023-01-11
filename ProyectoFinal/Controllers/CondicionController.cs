using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondicionController : ControllerBase
    {
        private readonly CondicionServicio _servicio;

        public CondicionController(CondicionServicio servicio)
        {
            _servicio = servicio;
        }


        [HttpGet]
        public async Task<ActionResult<List<Condicion>>> GetAllAsync()
        {

            var condiciones = await _servicio.GetAllAsync();
            return Ok(condiciones);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Condicion>> GetByIdAsync(int id)
        {
            var condicion = await _servicio.GetByIdAsync(id);

            if (condicion == null)
            {
                return NotFound();
            }
            return Ok(condicion);
        }

        [HttpPost]
        public async Task<ActionResult<Condicion>> AddAsync(Condicion condicion)
        {

            await _servicio.AddAsync(condicion);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = condicion.CondicionId }, condicion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, Condicion condicion)
        {
            if (id != condicion.CondicionId)
            {
                return BadRequest();
            }

            await _servicio.UpdateAsync(condicion);

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
