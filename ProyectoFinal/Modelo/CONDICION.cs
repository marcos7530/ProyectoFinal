using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class CONDICION
    {
        [Key]
        [MaxLength(2, ErrorMessage = "El id supera la cantidad maxima de {0} digitos.")]
        public int id_condicion { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "La descripcion de la condicion no puede tener mas de {0} caracteres.")]
        public string desc_condicion { get; set; }

    }
}
