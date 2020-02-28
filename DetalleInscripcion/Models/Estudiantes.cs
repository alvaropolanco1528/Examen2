using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InscriptionSIs.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage = "Se debe ingresar una matricula")]
        [StringLength(maximumLength: 9, MinimumLength = 9, ErrorMessage = ":La matricula ingresada es muy larga o muy corta (Debe contener 9 caracteres)")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "Se debe ingresar un nombre")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Se debe ingresar un balance")]
        [Range(typeof(decimal), minimum: "0", maximum: "100000000", ErrorMessage = "El valor del balance esta fuera de rango")]
        public decimal Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Matricula = string.Empty;
            Nombres = string.Empty;
            Balance = 0;
        }
    }
}
