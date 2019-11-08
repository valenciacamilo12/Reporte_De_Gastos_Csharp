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
        public decimal GastosTransportes { get; set; }
        [Required]
        public decimal GastosTransporteAereos { get; set; }
        [Required]
        public decimal GastosAlimenticios { get; set; }
        [Required]
        public decimal GastosHotelarios { get; set; }
        [Required]
        public decimal GastosImprevistos { get; set; }
        

        //Definicion LLaves Foraneas
        
        public int PaisRefID { get; set; }
        [ForeignKey("PaisRefID")]
        public virtual Pais Pais { get; set; }

        public int MonedaRefID { get; set; }
        [ForeignKey("MonedaRefID")]
        public virtual Moneda Moneda { get; set; }

        public int UsuarioRefID { get; set; }
        [ForeignKey("UsuarioRefID")]
        public virtual Usuario Usuario { get; set; }
        
    }
}
 