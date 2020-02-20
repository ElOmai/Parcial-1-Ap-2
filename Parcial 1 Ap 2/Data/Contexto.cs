using Microsoft.EntityFrameworkCore;
using Parcial_1_Ap_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_1_Ap_2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Inscripcion> Inscripcion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Database/Inscripcion.db");
        }
    }
}
