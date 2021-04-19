using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class UserCuentasNeg
    {
        UserCuentas datos = new UserCuentas();
        public AspNetUsers GetUser(string name)
        {
            return datos.GetUser(name);
        }
    }
}
