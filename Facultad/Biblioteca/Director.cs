using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Director : Empleado
    {
        public Director()
        {

        }

        public override string GetNombreCompleto()
        {
            return "Sr. Director " + _apellido;
        }
    }
}
