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
        public int ProductoId { get; set; }
        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }
        public Decimal Costo { get; set; }
        public Decimal Ganancia { get; set; }
        public Decimal Precio { get; set; }

        public Producto()
        {
            ProductoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
        }
        
    }
}
