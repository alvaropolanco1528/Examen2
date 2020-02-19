using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

 namespace BlazorApp1.Data
{

    public class Personas
    {
        [Key]
        public int PesonaId { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }



    }
}
