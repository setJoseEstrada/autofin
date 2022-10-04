using autofin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace autofin.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        MClientes _metodos = new MClientes();
        public ActionResult Index()
        {

            return View(_metodos.ConsultarTodos());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(t_clientes objClientes)
        {
            try
            {
                // TODO: Add insert logic here
                _metodos.Agregar(objClientes);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {

            return View(_metodos.Consultaruno(id));
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(t_clientes objCliente)
        {
            try
            {
                // TODO: Add update logic here
                _metodos.Modificar(objCliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
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
