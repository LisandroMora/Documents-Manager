using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class UsuarioDatos
    {
        static ProyectoFinalP2Entities DB = new ProyectoFinalP2Entities();
        
        public void NuevoUsuario(Usuarios usuario)
        {
            DB.Usuarios.Add(usuario);
            DB.SaveChanges();
        }

        public List<Usuarios> MostrarUsuario()
        {
            return DB.Usuarios.ToList();
        }

        public void EditarUsuario(int id, string nombre, string correo, int IdDepartamento, string cargo)
        {
            var registro = DB.Usuarios.Where(a => a.IdUsuario == id).FirstOrDefault();
            registro.Nombre = nombre;
            registro.Correo = correo;
            registro.IdDepartamento = IdDepartamento;
            registro.Cargo = cargo;
            DB.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var registro = DB.Usuarios.Find(id);
            DB.Usuarios.Remove(registro);
            DB.SaveChanges();
        }

        public Usuarios GetUsuarios(int id)
        {
            return DB.Usuarios.Where(a => a.IdUsuario == id).FirstOrDefault();
        }

        public Usuarios GetCuentaUsuarios(string cuenta)
        {
            return DB.Usuarios.Where(a => a.IdCuenta == cuenta).FirstOrDefault();
        }

        public List<ReporteUsuarios_Result> FiltarUsuario(string nombre)
        {
            return DB.ReporteUsuarios(nombre).ToList();
        }

    }
}
