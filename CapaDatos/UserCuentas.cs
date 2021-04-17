using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class UserCuentas
    {
        ProyectoFinalP2Entities db = new ProyectoFinalP2Entities();

        public AspNetUsers GetUser(string name)
        {
            var cuenta = db.AspNetUsers.Where(a => a.UserName == name).FirstOrDefault();
            return cuenta;
        }
    }
}
