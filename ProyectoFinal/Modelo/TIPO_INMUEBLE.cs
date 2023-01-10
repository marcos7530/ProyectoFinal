using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProyectoFinal.Modelo
{
    public class TIPO_INMUEBLE
    {
        [Key]
        [MaxLength(2, ErrorMessage ="El id supera la cantidad maxima de {0} digitos")]
        public int id_tipo_inmueble { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "La descripcion del tipo de inmueble no puede tener mas de {0} caracteres.")]
        public string desc_tipo_inmueble { get; set; }
    }
}
