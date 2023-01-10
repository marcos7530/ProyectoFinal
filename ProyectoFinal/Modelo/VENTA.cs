using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Modelo
{
    public class VENTA
    {
        [Key]
        [MaxLength(3, ErrorMessage = "El id supera la cantidad maxima de {0} digitos")]
        public int id_venta { get; set; }

        [Required]
        [ForeignKey("INMUEBLE")]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos")]
        public int id_inmueble { get; set; }

        [Required]
        [ForeignKey("CLIENTE")]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int id_cliente { get; set; }

        [Required]
        [ForeignKey("CONDICION")]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int id_condicion { get; set; }

        [Required]
        [ForeignKey("FORMA_PAGO")]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int id_forma_pago { get; set; }

        [MaxLength(255, ErrorMessage ="La descripcion no puede superar los {0} caracteres.")]
        public string? desc_venta { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El total de la venta no puede superar los {0} digitos.")]
        public int total_venta { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "El total del iva no puede superar los {0} digitos.")]
        public int total_iva { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "El total general no puede superar los {0} digitos.")]
        public int total_general { get; set; }

        [Required]
        public DateTime fecha_venta { get; set; }

    }
}
