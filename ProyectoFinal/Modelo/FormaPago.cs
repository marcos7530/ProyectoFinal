using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class FormaPago
    {
        [Key,MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos")]
        public int FormaPagoId { get; set; }

        [StringLength(100, ErrorMessage = "La descripcion no puede tener mas de {0} caracteres")]
        public string? FormaPagoDesc { get; set; }

        /*=================================================*/

        //public ICollection<Venta>? Ventas { get; set; }
    }
}
