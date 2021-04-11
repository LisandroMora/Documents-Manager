using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class DocumentosNegocio
    {
        DocumentosDatos datos = new DocumentosDatos();
        public void NuevoDocumento(EnvioDocumento documento)
        {
            datos.NuevoDocumento(documento);
        }
        public List<EnvioDocumento> MostrarDocumentos()
        {
            return datos.MostrarDocumentos();
        }
        public void GenerarSecuencia(EnvioDocumento documento)
        {
            string secuencia = $"{documento.Fecha.Year}";
        }
    }
}
