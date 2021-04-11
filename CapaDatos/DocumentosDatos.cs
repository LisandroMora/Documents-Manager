using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class DocumentosDatos
    {
        public ProyectoFinalP2Entities DB = new ProyectoFinalP2Entities();

        public void NuevoDocumento(EnvioDocumento documento)
        {
            DB.EnvioDocumento.Add(documento);
            DB.SaveChanges();
        }
        public List<EnvioDocumento> MostrarDocumentos()
        {
            return DB.EnvioDocumento.ToList();
        }
    }
}
