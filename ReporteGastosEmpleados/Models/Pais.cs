using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReporteGastosEmpleados.Models
{
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }
        [Required(ErrorMessage = "El nombre Del Pais Es Demasiado Largo")]
        [StringLength(55)]
        public string Nombre { get; set; }
        public ICollection<Reporte> Reportes { get; set; }
    }
}