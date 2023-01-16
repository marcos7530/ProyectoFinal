﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormaPagoController : ControllerBase
    {
        private readonly FormaPagoServicio _servicio;

        public FormaPagoController(FormaPagoServicio servicio)
        {
            _servicio = servicio;
        }


        [HttpGet]
        public async Task<ActionResult<List<FormaPago>>> GetAllAsync()
        {

            var formasPagos = await _servicio.GetAllAsync();
            return Ok(formasPagos);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<FormaPago>> GetByIdAsync(int id)
        {
            var formaPago = await _servicio.GetByIdAsync(id);

            if (formaPago == null)
            {
                return NotFound();
            }
            return Ok(formaPago);
        }

        [HttpPost]
        [ActionName(nameof(GetByIdAsync))]
        public async Task<ActionResult<FormaPago>> AddAsync(FormaPago formaPago)
        {

            await _servicio.AddAsync(formaPago);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = formaPago.FormaPagoId }, formaPago);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, FormaPago formaPago)
        {
            if (id != formaPago.FormaPagoId)
            {
                return BadRequest();
            }

            await _servicio.UpdateAsync(formaPago);

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
