using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReporteGastosEmpleados.Models
{
    public class Rol
    {
        public int RolId { get; set; }
        [Required(ErrorMessage = "El nombre Del No Es Valido ")]
        [StringLength(55)]
        public string TipoRol { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}