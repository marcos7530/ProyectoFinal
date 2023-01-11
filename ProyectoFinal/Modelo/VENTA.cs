using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Modelo
{
    public class Venta
    {
        [MaxLength(3, ErrorMessage = "El id supera la cantidad maxima de {0} digitos")]
        public int VentaId { get; set; }

        //[Required]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos")]
        public int InmuebleId { get; set; }
        public Inmueble Inmueble { get; set; }

        //[Required]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int ClienteId { get; set; }
        public ICollection<Cliente> Clientes { get; set; }

        //[Required]        
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int CondicionId { get; set; }
        public ICollection<Condicion> Condicions { get; set; }

        //[Required]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int FormaPagoId { get; set; }
        public ICollection<FormaPago> FormaPagos { get; set; }

        [MaxLength(255, ErrorMessage ="La descripcion no puede superar los {0} caracteres.")]
        public string? VentaDesc { get; set; }

        //[Required]
        [MaxLength(10, ErrorMessage = "El total de la venta no puede superar los {0} digitos.")]
        public int VentaTotal { get; set; }

        ///[Required]
        [MaxLength(8, ErrorMessage = "El total del iva no puede superar los {0} digitos.")]
        public int VentaTotalIva { get; set; }

        //[Required]
        [MaxLength(12, ErrorMessage = "El total general no puede superar los {0} digitos.")]
        public int VentaTotalGeneral { get; set; }

        //[Required]
        public DateTime VentaFecha { get; set; }

    }
}
