using ReporteGastosEmpleados.Models;
using ReporteGastosEmpleados.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ReporteGastosEmpleados.Controllers
{
    public class ReporteGastosController : Controller
    {
        private ReporteGastosServices _repo;
        public ReporteGastosController()
        {
            _repo = new ReporteGastosServices();

        }

        // GET: ReporteGastos
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        // GET: ReporteGastos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReporteGastos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReporteGastos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GastosTransportes,GastosTransporteAereos,GastosAlimenticios,GastosHotelarios,GastosImprevistos")] Reporte reporte)
        {
            try
            {
                using (var db = new AllContext())
                {
                    if (ModelState.IsValid)
                    {
                        db.Reportes.Add(reporte);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }

                }

            }
            catch (RetryLimitExceededException /* dex */)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(reporte);
        }


        // GET: ReporteGastos/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            using (var db = new AllContext())
            {
                Reporte reporte = db.Reportes.Find(Id);
                if (reporte == null)
                {

                    return HttpNotFound();
                }
                return View(reporte);
            }

        }

        // POST: BlogPost/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditReporte(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (var db = new AllContext())
            {
                var reporteUpdate = db.Reportes.Find(Id);
                if (TryUpdateModel(reporteUpdate, "",
                   new string[] { "GastosTransportes", "GastosTransporteAereos", "GastosAlimenticios", "GastosHotelarios", "GastosImprevistos" }))
                {
                    try
                    {
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    catch (RetryLimitExceededException /* dex */)
                    {
                        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                    }
                }
                return View(reporteUpdate);
            }

        }

        // GET: ReporteGastos/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            using (var db = new AllContext())
            {
                Reporte reporte = db.Reportes.Find(Id);
                if (reporte == null)
                {

                    return HttpNotFound();
                }
                return View(reporte);
            }
        }

        // POST: ReporteGastos/Delete/5
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteReporte(int? Id)
        {
            using (var db = new AllContext())
            {
                var query = (from p in db.Reportes
                             where p.ReporteId == Id
                             select p).Single();

                db.Reportes.Remove(query);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
