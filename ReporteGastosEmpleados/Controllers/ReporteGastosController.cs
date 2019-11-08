using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReporteGastosEmpleados.Controllers
{
    public class ReporteGastosController : Controller
    {
        // GET: ReporteGastos
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ReporteGastos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReporteGastos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ReporteGastos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReporteGastos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
