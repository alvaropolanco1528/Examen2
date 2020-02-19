using Microsoft.EntityFrameworkCore;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Data
{
    public class Contexto : DbContext
    {
      public DbSet<Contexto> inscribir { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Database/Inscripcion");
        }

    }
}
