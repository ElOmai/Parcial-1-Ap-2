using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_1_Ap_2.Models
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }
        [Required]
        public string Semestre { get; set; }
        [Required, Range(1, 100)]
        public int Limite { get; set; }
        [Required, Range(1, 100)]
        public int Tomados { get; set; }
        [Required, Range(1, 100)]
        public int Disponibles { get; set; }
    }
}
