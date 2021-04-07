using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion.Controllers
{
    [Authorize]
    public class DepartamentosController : Controller
    {
        DepartamentosNegocio DepNegocio = new DepartamentosNegocio();
        // GET: Departamentos
        public ActionResult Inicio()
        {
            return View();
        }

        // GET: Departamentos/Details/5
        public ActionResult Lista()
        {
            return View(DepNegocio.MostrarDepartamentos());
        }

        // GET: Departamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamentos/Create
        [HttpPost]
        public ActionResult Create(Departamentos dept)
        {
            try
            {
                DepNegocio.NuevoDepartamento(dept);

                return RedirectToAction("Inicio");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamentos/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Departamentos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, string nombre, string siglas)
        {
            try
            {
                DepNegocio.EditarDepartamento(id, nombre, siglas);

                return RedirectToAction("Inicio");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamentos/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Departamentos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                DepNegocio.EliminarDepartamento(id);

                return RedirectToAction("Inicio");
            }
            catch
            {
                return View();
            }
        }
    }
}
