using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion3.Controllers
{
    public class DocumentosController : Controller
    {
        DocumentosNegocio negocio = new DocumentosNegocio();
        // GET: Documentos
        public ActionResult InicioDocumentos()
        {
            return View();
        }

        // GET: Documentos/Details/5
        public ActionResult Lista()
        {
            return View(negocio.MostrarDocumentos());
        }

        // GET: Documentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Documentos/Create
        [HttpPost]
        public ActionResult Create(EnvioDocumento documentos)
        {
            negocio.NuevoDocumento(documentos);

            return RedirectToAction("InicioDocumentos");
        }

        // GET: Documentos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Documentos/Edit/5
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

        // GET: Documentos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Documentos/Delete/5
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
