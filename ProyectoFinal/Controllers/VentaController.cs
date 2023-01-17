using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly VentaServicio _servicio;

        public VentaController(VentaServicio servicio)
        {
            _servicio = servicio;
        }


        [HttpGet]
        public async Task<ActionResult<List<Venta>>> GetAllAsync()
        {

            var ventas = await _servicio.GetAllAsync();
            return Ok(ventas);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> GetByIdAsync(int id)
        {
            var venta = await _servicio.GetByIdAsync(id);

            if (venta == null)
            {
                return NotFound();
            }
            return Ok(venta);
        }

        [HttpPost]
        public async Task<ActionResult<Venta>> AddAsync(Venta venta)
        {

            await _servicio.AddAsync(venta);
            //return CreatedAtAction(nameof(GetByIdAsync), new { id = venta.VentaId }, venta);

            return Ok(venta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, Venta venta)
        {
            if (id != venta.VentaId)
            {
                return BadRequest();
            }

            await _servicio.UpdateAsync(venta);

            //return NoContent();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _servicio.DeleteAsync(id);
            //return NoContent();
            return Ok();
        }



    }
}
