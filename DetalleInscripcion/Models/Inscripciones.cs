using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InscriptionSIs.Models
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        [Required(ErrorMessage = "Es necesario definir un semestre")]
        [StringLength(maximumLength: 7, MinimumLength = 6, ErrorMessage = "La cadena del semestre esta fuera de rango")]
        public string Semestre { get; set; }
        [Required(ErrorMessage = "Es necesario definir un limite")]
        [Range(typeof(int), minimum: "6", maximum: "100", ErrorMessage = "El limite esta fuera de rango, es muy corto o largo")]
        public int Limite { get; set; }
        [Required(ErrorMessage = "Es necesario definir una cantidad de creditos tomados")]
        [Range(typeof(int), minimum: "1", maximum: "100", ErrorMessage = "La cantidad de creditos tomados esta fuera de rango")]
        public int Tomados { get; set; }
        [Required(ErrorMessage = "Es necesario definir una cantidad de creditos desponible")]
        [Range(typeof(int), minimum: "0", maximum: "100", ErrorMessage = "La cantidad de creditos disponibles esta fuera de rango")]
        public int Disponibles { get; set; }
        [Required(ErrorMessage = "Es necesario definir una fecha")]
        [Range(typeof(DateTime), minimum: "1/1/2000", maximum: "1/1/2025", ErrorMessage = "La fecha esta fuera de rango")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Es necesario ingresar el Id del estudiante")]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage = "Es necesario introducir un monto")]
        [Range(typeof(decimal), minimum: "0", maximum: "10000000000", ErrorMessage = "La cantidad del monto esta fuera de rango")]
        public decimal Monto { get; set; }
        [Required(ErrorMessage = "Es necesario establecer un balance")]
        [Range(typeof(decimal), minimum: "0", maximum: "10000000000", ErrorMessage = "La cantidad del balance esta fuera de rango")]
        public decimal Balance { get; set; }

        [ForeignKey("InscripcionId")]
        public List<InscripcionDetalles> Asignaturas { get; set; }


        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles = 0;
            Fecha = DateTime.Now;
            EstudianteId = 0;
            Monto = 0;
            Balance = 0;
            Asignaturas = new List<InscripcionDetalles>();
        }
    }
}
