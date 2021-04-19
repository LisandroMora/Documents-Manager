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
        ProyectoFinalP2Entities DB = new ProyectoFinalP2Entities();

        public void NuevoDocumento(EnvioDocumento documento)
        {
            DB.EnvioDocumento.Add(documento);
            DB.SaveChanges();
        }
        public List<EnvioDocumento> MostrarDocumentos()
        {
            return DB.EnvioDocumento.ToList();
        }
        public int LastID()
        {
            int id;
            if (DB.EnvioDocumento.Count() != 0)
            {
                 id = DB.EnvioDocumento.Select(x=>x.IdEnvio).Max();
            }
            else
            {
                id = 0;
            }
            return id;
        }
        public void EliminarDocumento(int id)
        {
            var registro = DB.EnvioDocumento.Where(a => a.IdEnvio == id).FirstOrDefault();
            DB.EnvioDocumento.Remove(registro);
            DB.SaveChanges();
        }
        public EnvioDocumento GetDocumento(int ID)
        {
            return DB.EnvioDocumento.Where(a => a.IdEnvio == ID).FirstOrDefault();
        }
    }
}
