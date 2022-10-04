using autofin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace autofin.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        MProductos _metodos = new MProductos();
        public ActionResult Index() => View(_metodos.ConsultarTodos());
     

        // GET: Productos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        public ActionResult Create(t_productos objProductos)
        {
            try
            {
                // TODO: Add insert logic here
                _metodos.Agregar(objProductos);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Productos/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_metodos.Consultaruno(id));
        }

        // POST: Productos/Edit/5
        [HttpPost]
        public ActionResult Edit(t_productos objProductos)
        {
            try
            {
                // TODO: Add update logic here
                _metodos.Modificar(objProductos);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Productos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Productos/Delete/5
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
