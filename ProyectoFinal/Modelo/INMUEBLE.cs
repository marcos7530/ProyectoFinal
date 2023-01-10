using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Modelo
{
    public class INMUEBLE
    {
        [Key]
        public int id_inmueble { get; set; }

        [ForeignKey("TIPO_INMUEBLE")]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int id_tipo_inmueble { get; set; }

        [MaxLength(255, ErrorMessage ="La descripcion del inmueble no puede tener mas de {0} caracteres.")]
        public string? desc_inmueble { get; set; }

        [MaxLength(255, ErrorMessage = "La ubicacion del inmueble no puede tener mas de {0} caracteres.")]
        public string? ubic_inmueble { get; set; }
        
        [Required]        
        [MaxLength(12, ErrorMessage ="El costo del inmueble no puede ser mayor a {0} digitos.")]
        public int costo_inmueble { get; set; }
    }
}
