using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InscriptionSIs.Models
{
    public class Pagos
    {
        [Key]
        public int PagoId { get; set; }
        [Required(ErrorMessage = "Es necesario introducir una fecha")]
        [Range(typeof(DateTime), minimum: "1/1/2000", "1/1/2030")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Es ncesario introducir un Id de Inscripcion")]
        public int InscripcionId { get; set; }
        [Required(ErrorMessage = "Es necesario introducir un monto")]
        [Range(typeof(decimal), minimum: "0", maximum: "10000000000", ErrorMessage = "La cantidad del monto esta fuera de rango")]
        public decimal Monto { get; set; }


        public Pagos()
        {
            PagoId = 0;
            Fecha = DateTime.Now;
            InscripcionId = 0;
            Monto = 0;
        }
    }
}
