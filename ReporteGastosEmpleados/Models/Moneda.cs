using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReporteGastosEmpleados.Models
{
    public class Moneda
    {
        [Key]
        public int MonedaId { get; set; }
        [StringLength(55)]
        [Display(Name = "Tipo De Moneda")]
        public string TipoMoneda { get; set; }
        public ICollection<Reporte> Reportes { get; set; }
    }
} 