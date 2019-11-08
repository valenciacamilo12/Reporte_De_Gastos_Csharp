using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReporteGastosEmpleados.Models;


namespace ReporteGastosEmpleados.Services
{
    public class ReporteGastosServices
    {
        public List<Reporte> ObtenerTodos()
        {
            using (var db = new AllContext())
            {
                return db.Reportes.ToList();
            }
        }

    }
}