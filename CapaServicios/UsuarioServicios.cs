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
        UsuarioDatos datos = new UsuarioDatos();
        public List<ReporteUsuarios_Result> FiltarUsuario(string nombre)
        {
            return datos.FiltarUsuario(nombre);
        }

    }
}
