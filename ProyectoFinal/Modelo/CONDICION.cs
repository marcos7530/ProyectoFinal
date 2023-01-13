using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class Condicion
    {
        [Key,MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int CondicionId { get; set; }

        [MaxLength(100, ErrorMessage = "La descripcion de la condicion no puede tener mas de {0} caracteres.")]
        public string? CondicionDesc { get; set; }

        /*====================================================*/

        public ICollection<Venta> Ventas { get; set; }

    }
}
