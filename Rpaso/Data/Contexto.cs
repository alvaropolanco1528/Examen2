using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rpaso.MODELS;

namespace Rpaso.Data
{
    public class Contexto : DbContext
    {
        public DbSet <ARTICLOS> aRTICLOs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite(@"data source=DataBase"));
        }
    }
}
