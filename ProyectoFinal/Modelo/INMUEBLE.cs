using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Modelo
{
    public class Inmueble
    {
        [Key]/*, MaxLength(3, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")*/
        public int InmuebleId { get; set; }

        [ForeignKey("TipoInmueble")]/*, MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")*/
        public int TipoInmuebleId { get; set; }

        [MaxLength(255, ErrorMessage ="La descripcion del inmueble no puede tener mas de {0} caracteres.")]
        public string? InmuebleDesc { get; set; }

        [MaxLength(255, ErrorMessage = "La ubicacion del inmueble no puede tener mas de {0} caracteres.")]
        public string? InmuebleUbic { get; set; }
              
        //[MaxLength(12, ErrorMessage ="El costo del inmueble no puede ser mayor a {0} digitos.")]
        public int InmuebleCosto { get; set; }


        /*===============================================*/
        //public Venta? Ventas { get; set; }
        //public TipoInmueble? Tipo { get; set; }
    }
}
