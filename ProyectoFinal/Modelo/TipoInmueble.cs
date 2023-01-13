using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProyectoFinal.Modelo
{
    public class TipoInmueble
    {
        [Key,MaxLength(2, ErrorMessage ="El id supera la cantidad maxima de {0} digitos")]
        public int TipoInmuebleId { get; set; }

        [MaxLength(255, ErrorMessage = "La descripcion del tipo de inmueble no puede tener mas de {0} caracteres.")]
        public string? TipoInmuebleDesc { get; set; }

        /*===================================================*/
        public ICollection<Inmueble>? Inmueble { get; set; }
    }
}
