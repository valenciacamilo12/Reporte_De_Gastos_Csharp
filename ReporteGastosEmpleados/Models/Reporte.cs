using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReporteGastosEmpleados.Models
{
    public class Reporte
    {
        [Key]
        public int ReporteId { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal GastosTransportes { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal GastosTransporteAereos { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 3)")]
        public decimal GastosAlimenticios { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal GastosHotelarios { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal GastosImprevistos { get; set; }

        //Definicion LLaves Foraneas
        [ForeignKey("Pais")]
        public int PaisRefId { get; set; }
        public Pais Pais { get; set; }

        [ForeignKey("Moneda")]
        public int MonedaRefId { get; set; }
        public Moneda Moneda { get; set; }

        [ForeignKey("Eampleado")]
        public int EmpleadoRefId { get; set; }
        public Empleado Empleado { get; set; }

            



    }
}