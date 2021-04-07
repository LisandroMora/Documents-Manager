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
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        UsuarioNegocio UserNegocio = new UsuarioNegocio();
        public ActionResult Inicio()
        {
            return View();
        }

        // GET: Usuarios/Details/5
        public ActionResult Lista()
        {
            return View(UserNegocio.MostrarUsuario());
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Usuarios usuario)
        {
                UserNegocio.NuevoUsuario(usuario);

                return RedirectToAction("Inicio");
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, string nombre, string correo, int IdDepartamento, string cargo)
        {
            UserNegocio.EditarUsuario(id, nombre, correo, IdDepartamento, cargo);
            return RedirectToAction("Inicio");
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                UserNegocio.Eliminar(id);

                return RedirectToAction("Inicio");
            }
            catch
            {
                return View();
            }
        }
    }
}
