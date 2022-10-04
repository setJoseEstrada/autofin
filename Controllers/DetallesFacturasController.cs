using autofin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace autofin.Controllers
{
    public class DetallesFacturasController : Controller
    {
        // GET: DetallesFacturas
        MDFactura _metodos = new MDFactura();
        public ActionResult Index() => View(_metodos.ConsultarTodos());
        

        // GET: DetallesFacturas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DetallesFacturas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetallesFacturas/Create
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

        // GET: DetallesFacturas/Edit/5
        public ActionResult Edit(int id)
        {

            return View(_metodos.Consultaruno(id));
        }

        // POST: DetallesFacturas/Edit/5
        [HttpPost]
        public ActionResult Edit(t_detalleFactura t_DetalleFactura)
        {
            try
            {
                // TODO: Add update logic here
                _metodos.Modificar(t_DetalleFactura);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DetallesFacturas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DetallesFacturas/Delete/5
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
