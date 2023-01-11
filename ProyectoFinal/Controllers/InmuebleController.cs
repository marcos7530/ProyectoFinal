using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmuebleController : ControllerBase
    {
        private readonly InmuebleServicio _servicio;

        public InmuebleController(InmuebleServicio servicio)
        {
            _servicio = servicio;
        }


        [HttpGet]
        public async Task<ActionResult<List<Inmueble>>> GetAllAsync()
        {

            var inmuebles = await _servicio.GetAllAsync();
            return Ok(inmuebles);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Inmueble>> GetByIdAsync(int id)
        {
            var inmueble = await _servicio.GetByIdAsync(id);

            if (inmueble == null)
            {
                return NotFound();
            }
            return Ok(inmueble);
        }

        [HttpPost]
        public async Task<ActionResult<Inmueble>> AddAsync(Inmueble inmueble)
        {

            await _servicio.AddAsync(inmueble);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = inmueble.InmuebleId }, inmueble);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, Inmueble inmueble)
        {
            if (id != inmueble.InmuebleId)
            {
                return BadRequest();
            }

            await _servicio.UpdateAsync(inmueble);

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
