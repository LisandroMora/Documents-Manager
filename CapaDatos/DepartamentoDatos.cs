using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class DepartamentoDatos
    {
        static ProyectoFinalP2Entities DB = new ProyectoFinalP2Entities();

        public void NuevoDepartamento(Departamentos depart)
        {
            DB.Departamentos.Add(depart);
            DB.SaveChanges();
        }

        public List<Departamentos> MostrarDepartamentos()
        {
            return DB.Departamentos.ToList();
        }

        public void EditarDepartamento(int id, string nombre, string siglas)
        {
            var registro = DB.Departamentos.Where(a => a.IdDepartamento == id).FirstOrDefault();
            registro.Nombre = nombre;
            registro.Siglas = siglas;
            DB.SaveChanges();
        }

        public void EliminarDepartamento(int id)
        {
            var registro = DB.Departamentos.Where(a => a.IdDepartamento == id).FirstOrDefault();
            DB.Departamentos.Remove(registro);
            DB.SaveChanges();
        }

        public Departamentos GetDepartamentos(int ID)
        {
            return DB.Departamentos.Where(a => a.IdDepartamento == ID).FirstOrDefault();
        }
    }
}
