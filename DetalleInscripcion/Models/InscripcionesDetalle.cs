using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InscriptionSIs.Models
{
    public class InscripcionDetalles
    {
        [Key]
        public int DetalleId { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }
        public string AsignaturaDescripcion { get; set; }
        public int Creditos { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }

        public InscripcionDetalles()
        {
            DetalleId = 0;
            AsignaturaId = 0;
            Creditos = 0;
            Precio = 0;
            SubTotal = 0;
        }
    }
}
