using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class DepartamentosNegocio
    {
        DepartamentoDatos datos = new DepartamentoDatos();
        public void NuevoDepartamento(Departamentos depart)
        {
            datos.NuevoDepartamento(depart);
        }

        public List<Departamentos> MostrarDepartamentos()
        {
            return datos.MostrarDepartamentos();
        }

        public void EditarDepartamento(int id, string nombre, string siglas)
        {
            datos.EditarDepartamento(id, nombre, siglas);
        }

        public void EliminarDepartamento(int id)
        {
            datos.EliminarDepartamento(id);
        }
    }
}
