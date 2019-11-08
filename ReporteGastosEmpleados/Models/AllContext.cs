using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace ReporteGastosEmpleados.Models
{
    public class AllContext :DbContext
    {
        public AllContext()
         : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reporte>().Property(reporte => reporte.GastosTransportes).HasPrecision(18, 3);
            modelBuilder.Entity<Reporte>().Property(reporte => reporte.GastosHotelarios).HasPrecision(18, 3);
            modelBuilder.Entity<Reporte>().Property(reporte => reporte.GastosImprevistos).HasPrecision(18, 3);
            modelBuilder.Entity<Reporte>().Property(reporte => reporte.GastosTransporteAereos).HasPrecision(18, 3);
            modelBuilder.Entity<Reporte>().Property(reporte => reporte.GastosTransportes).HasPrecision(18, 3);
            
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Reporte> Reportes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}