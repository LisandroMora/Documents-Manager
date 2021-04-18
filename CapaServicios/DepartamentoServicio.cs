using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaServicios
{
    public class DepartamentoServicio
    {
        ProyectoFinalP2Entities db = new ProyectoFinalP2Entities();
        public List<ReporteDepartamentos_Result> FiltrarDept(string nombre)
        {
            return db.ReporteDepartamentos(nombre).ToList();
        }
    }
}
