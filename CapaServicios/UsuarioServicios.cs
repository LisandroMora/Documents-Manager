using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaServicios
{
    public class UsuarioServicios
    {
        ProyectoFinalP2Entities db = new ProyectoFinalP2Entities();
        public List<ReporteUsuarios_Result> FiltarUsuario(string nombre)
        {
            return db.ReporteUsuarios(nombre).ToList();
        }
    }
}
