using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class FORMA_PAGO
    {
        [Key]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos")]
        public int id_forma_pago { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La descripcion no puede tener mas de {0} caracteres")]
        public string des_forma_pago { get; set; } 
    }
}
