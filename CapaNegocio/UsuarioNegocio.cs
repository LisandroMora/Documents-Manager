using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        static UsuarioDatos datos = new UsuarioDatos();
        public void NuevoUsuario(Usuarios usuario)
        {
            datos.NuevoUsuario(usuario);
        }

        public List<Usuarios> MostrarUsuario()
        {
            return datos.MostrarUsuario();
        }

        public void EditarUsuario(int id, string nombre, string correo, int IdDepartamento, string cargo)
        {
            datos.EditarUsuario(id, nombre, correo, IdDepartamento, cargo);
        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
        }
        public static Usuarios GetUsuarios(int id)
        {
            return UsuarioDatos.GetUsuarios(id);
        }
        public static Usuarios GetCuentaUsuarios(string cuenta)
        {
            return UsuarioDatos.GetCuentaUsuarios(cuenta);
        }
    }
}
