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
        [StringLength(55)]
        [Required(ErrorMessage = "El nombre Del No Es Valido ")]
        public string TipoRol { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}