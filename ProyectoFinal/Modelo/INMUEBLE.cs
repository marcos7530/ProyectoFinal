using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Modelo
{
    public class INMUEBLE
    {
        [Key]
        public int id_inmueble { get; set; }

        [ForeignKey("")]
        public int id_tipo_inmueble { get; set; }

        public string desc_inmueble { get; set; }

        public string ubic_inmueble { get; set; }

        public double costo_inmueble { get; set; }
    }
}
