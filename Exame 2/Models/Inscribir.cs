using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exame_2.Models
{
    public class Inscribir
    {

        [Key]
        public int Matricula { get; set; }
        public DateTime Fecha { get; set; }
        public int Semestre { get; set; }
        public int Limite { get; set; }
        public int Tomados { get; set; }
        public int Disponible { get; set; }

        public Inscribir()
        {
            Matricula = 0;
            Fecha = DateTime.Now;
            Semestre = 0;
            Limite = 0;
            Tomados = 0;
            Disponible = 0;
        }

    }
}
}
