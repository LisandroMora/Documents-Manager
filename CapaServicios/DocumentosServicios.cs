using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaServicios
{
    public class DocumentosServicios
    {
        ProyectoFinalP2Entities db = new ProyectoFinalP2Entities();

        public List<ReporteDocumentos_Result> FiltrarDocumentos(string filtro, string consulta)
        {
            return db.ReporteDocumentos(filtro, consulta).ToList();
        }
        public List<ReporteDocFecha_Result> FiltrarDocumentosXFecha(string desde, string hasta)
        {
            return db.ReporteDocFecha(desde, hasta).ToList();
        }
    }
}
