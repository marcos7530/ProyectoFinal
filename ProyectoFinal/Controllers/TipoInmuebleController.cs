using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoInmuebleController : ControllerBase
    {

        private readonly TipoInmuebleServicio _servicio;

        public TipoInmuebleController(TipoInmuebleServicio servicio)
        {
            _servicio = servicio;
        }


        [HttpGet]
        public async Task<ActionResult<List<TipoInmueble>>> GetAllAsync()
        {

            var tiposInmuebles = await _servicio.GetAllAsync();
            return Ok(tiposInmuebles);
        }


        [HttpGet("(id)")]
        public async Task<ActionResult<TipoInmueble>> GetByIdAsync(int id)
        {
            var tipoInmueble = await _servicio.GetByIdAsync(id);

            if (tipoInmueble == null)
            {
                return NotFound();
            }
            return Ok(tipoInmueble);
        }

        [HttpPost]
        public async Task<ActionResult<TipoInmueble>> AddAsync(TipoInmueble tipoInmueble)
        {

            await _servicio.AddAsync(tipoInmueble);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = tipoInmueble.TipoInmuebleId }, tipoInmueble);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, TipoInmueble tipoInmueble)
        {
            if (id != tipoInmueble.TipoInmuebleId)
            {
                return BadRequest();
            }

            await _servicio.UpdateAsync(tipoInmueble);

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
