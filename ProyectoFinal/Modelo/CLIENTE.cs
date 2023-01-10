using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class CLIENTE
    {
        [Key]
        [MaxLength(3, ErrorMessage = "El id supera la cantidad maxima de {0} digitos")]
        public int id_cliente { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El nombre del cliente no puede tener mas de {0} caracteres.")]
        public string nombre_cliente { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "La direccion del cliente no puede tener mas de {0} caracteres.")]
        public string dir_cliente { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="El formato del correo ingresado no es correcto")]
        [MaxLength(50, ErrorMessage = "El correo del cliente no puede ter mas de {0} caracteres.")]
        public string correo_cliente { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage ="El telefono del cliente no puede tener mas de {0} caracteres.")]
        public string telefono_cliente { get; set; }


    }
}
