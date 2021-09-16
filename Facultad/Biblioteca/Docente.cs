using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Docente : Empleado
    {
        public Docente()
        {

        }

        public override string GetNombreCompleto()
        {
            return "Docente " + _nombre;
        }
    }
}
