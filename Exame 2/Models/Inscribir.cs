using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class Producto
    {
        [Key]
        public int Matricula { get; set; }
        public DateTime Fecha { get; set; }
        public int Semestre { get; set; }
        public int Limite { get; set; }
        public int Tomados { get; set; }
        public int Disponible { get; set; }

        public Producto()
        {
            Matricula = 0;
            Fecha =DateTime.Now;
            Semestre = 0;
            Limite = 0;
            Tomados = 0;
            Disponible = 0;
        }

    }
}