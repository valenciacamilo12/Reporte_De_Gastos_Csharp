using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReporteGastosEmpleados.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioInt { get; set; }
        [Required(ErrorMessage="Introduce Tu Nombre")]
        [StringLength(55)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Introduce Tu Apellido")]
        [StringLength(55)]
        public string Apellido { get; set; }
        [Range(-10000000000, 100000000000)]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "Introduce Tu Area De Trabajo")]
        [StringLength(55)]
        public string Area { get; set; }
        [Required(ErrorMessage = "Introduce Tu Cargo")]
        [StringLength(55)]
        public string Cargo { get; set; }
        public int TipoRolRefID { get; set; }
        [ForeignKey("TipoRolRefID")]
        public virtual Rol Rol { get; set; }

        public ICollection<Reporte> Reportes { get; set; }
       
    }
}