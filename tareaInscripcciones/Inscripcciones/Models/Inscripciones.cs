using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Inscripcciones.Models
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        
        public string Semestre { get; set; }
        
        public int Limite { get; set; }
        
        public int Tomados { get; set; }
        
        public int Disponibles { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles = 0;
        }

    }
}
