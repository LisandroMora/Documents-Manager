using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidades;
using CapaNegocio;
using CapaServicios;

namespace CapaPresentacion3.Controllers
{
    [Authorize]
    public class DocumentosController : Controller
    {
        DocumentosNegocio negocio = new DocumentosNegocio();
        UsuarioNegocio UserNegocio = new UsuarioNegocio();
        UserCuentasNeg cuenta = new UserCuentasNeg();
        DepartamentosNegocio departamentos = new DepartamentosNegocio();
        DocumentosServicios servicios = new DocumentosServicios();
        

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

        [HttpPost]
        public ActionResult Filtro(string filtro, string consulta)
        {
            return View(servicios.FiltrarDocumentos(filtro, consulta));
        }

        [HttpPost]
        public ActionResult FiltroBusqueda(string desde, string hasta)
        {
            return View(servicios.FiltrarDocumentosXFecha(desde, hasta));
        }

        // GET: Documentos/Create
        public ActionResult Create()
        {
            List<SelectListItem> ListaUsuarios = UserNegocio.MostrarUsuario().ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.IdUsuario.ToString(),
                    Selected = false
                };
            });
            List<SelectListItem> ListaDept = departamentos.MostrarDepartamentos().ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.IdDepartamento.ToString(),
                    Selected = false
                };
            });

            ViewBag.items2 = ListaDept;

            ViewBag.items = ListaUsuarios;
            return View();
        }

        // POST: Documentos/Create
        [HttpPost]
        public ActionResult Create(EnvioDocumento documentos)
        {
            var usuario = cuenta.GetUser(User.Identity.Name);
            var empleado = UserNegocio.GetCuentaUsuarios(usuario.Id);
            documentos.IdUsuario = empleado.IdUsuario;
            negocio.NuevoDocumento(documentos);
            return RedirectToAction("InicioDocumentos");
        }

        // GET: Documentos/Delete/5
        public ActionResult Delete(int id)
        {
            return View(negocio.GetDocumento(id));
        }

        // POST: Documentos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            negocio.EliminarDocumento(id);

            return RedirectToAction("InicioDocumentos");
        }
    }
}
