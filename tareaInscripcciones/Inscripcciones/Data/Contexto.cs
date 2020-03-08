using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inscripcciones.Models;
using Microsoft.EntityFrameworkCore;

namespace Inscripcciones.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Inscripciones> Inscripciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DataBase/Data.db");
        }
    }
}

