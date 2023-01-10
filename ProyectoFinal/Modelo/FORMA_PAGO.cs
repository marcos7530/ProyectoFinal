using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class FORMA_PAGO
    {
        [Key]        
        public int id_forma_pago { get; set; }

        [StringLength(100, ErrorMessage = "La descripcion no puede tener mas de {0} caracteres")]
        public string des_forma_pago { get; set; } 
    }
}
