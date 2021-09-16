using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo { get => _apodo; }

        public Bedel()
        {

        }

        public override string GetNombreCompleto()
        {
            return "Bedel " + _apodo;
        }
    }
}
