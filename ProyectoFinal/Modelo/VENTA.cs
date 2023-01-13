using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Modelo
{
    public class Venta
    {
        
        [Key, MaxLength(3, ErrorMessage = 
            "El id supera la cantidad maxima de {0} digitos")]
        public int VentaId { get; set; }

        [ForeignKey("Inmueble"), MaxLength(2, ErrorMessage = 
            "El id supera la cantidad maxima de {0} digitos")]
        public int? InmuebleId { get; set; }
        
        [ForeignKey("Cliente"), MaxLength(2, ErrorMessage = 
            "El id supera la cantidad maxima de {0} digitos.")]
        public int? ClienteId { get; set; }
                
        [ForeignKey("Condicion"), MaxLength(2, ErrorMessage = 
            "El id supera la cantidad maxima de {0} digitos.")]
        public int? CondicionId { get; set; }
               
        [ForeignKey("FormaPago"), MaxLength(2, ErrorMessage = 
            "El id supera la cantidad maxima de {0} digitos.")]
        public int? FormaPagoId { get; set; }
        
        [MaxLength(255, ErrorMessage =
            "La descripcion no puede superar los {0} caracteres.")]
        public string? VentaDesc { get; set; }

        [MaxLength(10, ErrorMessage = 
            "El total de la venta no puede superar los {0} digitos.")]
        public int VentaTotal { get; set; }
        
        [MaxLength(8, ErrorMessage = 
            "El total del iva no puede superar los {0} digitos.")]
        public int VentaTotalIva { get; set; }

        [MaxLength(12, ErrorMessage = 
            "El total general no puede superar los {0} digitos.")]
        public int VentaTotalGeneral { get; set; }

        public DateTime VentaFecha { get; set; }

        /*=============================================*/
        public Inmueble Inmueble { get; set; }
        public Condicion Condicion { get; set; }
        public Cliente Cliente { get; set; }
        public FormaPago FormaPago { get; set; }
    }
}
