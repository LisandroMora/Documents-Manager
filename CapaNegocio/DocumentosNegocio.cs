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
            DepartamentoDatos.GetDepartamentos(documento.IdDeptOrigen);
            string secuencia = $"{documento.Fecha.Year}-{DepartamentoDatos.GetDepartamentos(documento.IdDeptOrigen).Siglas}-" +
                $"{DepartamentoDatos.GetDepartamentos(documento.IdDeptDestino).Siglas}-{digitos+numero}";
            documento.Secuencia = secuencia;
        }

        public void DeterminarOrigen(EnvioDocumento documento)
        {
            documento.IdDeptOrigen = UsuarioDatos.GetUsuarios(documento.IdUsuario).IdDepartamento;
        }

        public void DeterminarUsuario()
        {

        }
    }
}
