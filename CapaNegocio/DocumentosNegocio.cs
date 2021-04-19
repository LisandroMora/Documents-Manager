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
        UsuarioDatos usuario = new UsuarioDatos();
        DepartamentoDatos depart = new DepartamentoDatos();
        public void NuevoDocumento(EnvioDocumento documento)
        {
            DeterminarOrigen(documento);
            GenerarSecuencia(documento);
            datos.NuevoDocumento(documento);
        }
        public List<EnvioDocumento> MostrarDocumentos()
        {
            return datos.MostrarDocumentos();
        }
        public void GenerarSecuencia(EnvioDocumento documento)
        {
            string digitos;
            int numero = datos.LastID() + 1;
            if (numero < 10) digitos = "000";
            else if (numero < 100 && numero > 9) digitos = "00";
            else digitos = "0";
            string secuencia = $"{documento.Fecha.Year}-{depart.GetDepartamentos(documento.IdDeptOrigen).Siglas}-" +
                $"{depart.GetDepartamentos(documento.IdDeptDestino).Siglas}-{digitos+numero}";
            documento.Secuencia = secuencia;
        }

        public void DeterminarOrigen(EnvioDocumento documento)
        {
            documento.IdDeptOrigen = usuario.GetUsuarios(documento.IdUsuario).IdDepartamento;
        }
        public void EliminarDocumento(int id)
        {
            datos.EliminarDocumento(id);
        }
        public EnvioDocumento GetDocumento(int ID)
        {
            return datos.GetDocumento(ID);
        }
    }
}
