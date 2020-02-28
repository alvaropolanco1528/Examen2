using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InscriptionSIs.Models
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        [Required(ErrorMessage = "Es necesario introducir un codigo")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "Es necesario introducir una descripcion")]
        [StringLength(maximumLength: 99, ErrorMessage = "La logitud de la descripcion esta fuera de rango")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Es necesario introducir un PreRequisito")]
        public int PreRequisito { get; set; }
        [Required(ErrorMessage = "Es necesario introducir los creditos")]
        [Range(typeof(int), minimum: "1", maximum: "10", ErrorMessage = "La cantidad de creditos esta fuera de rango (10 creditos Maximo)")]
        public int Creditos { get; set; }

        public Asignaturas()
        {
            AsignaturaId = 0;
            Codigo = string.Empty;
            Descripcion = string.Empty;
            PreRequisito = 0;
            Creditos = 0;
        }
    }
}