using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReporteGastosEmpleados.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoInt { get; set; }
        [Required(ErrorMessage="Introduce Tu Nombre")]
        [StringLength(55)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Introduce Tu Apellido")]
        [StringLength(55)]
        public string Apellido { get; set; }
        [Column(TypeName = "INT(11)")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "Introduce Tu Area De Trabajo")]
        [StringLength(55)]
        public string Area { get; set; }
        [Required(ErrorMessage = "Introduce Tu Cargo")]
        [StringLength(55)]
        public string Cargo { get; set; }
    }
}