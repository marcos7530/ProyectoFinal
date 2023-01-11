using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class Cliente
    {
        [MaxLength(3, ErrorMessage = "El id supera la cantidad maxima de {0} digitos")]
        public int Id { get; set; }

        //[Required]
        [MaxLength(50, ErrorMessage = "El nombre del cliente no puede tener mas de {0} caracteres.")]
        public string ClienteNombre { get; set; }
        //[Required]
        [MaxLength(255, ErrorMessage = "La direccion del cliente no puede tener mas de {0} caracteres.")]
        public string CleinteDireccion { get; set; }

        //[Required]
        [EmailAddress(ErrorMessage ="El formato del correo ingresado no es correcto")]
        [MaxLength(50, ErrorMessage = "El correo del cliente no puede ter mas de {0} caracteres.")]
        public string ClienteCorreo { get; set; }

        //[Required]
        [MaxLength(12, ErrorMessage ="El telefono del cliente no puede tener mas de {0} caracteres.")]
        public string ClienteTelefono { get; set; }


    }
}
