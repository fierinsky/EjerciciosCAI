using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Alumno : Persona
    {
        private int _codigo;

        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }

        public string Credencial
        {
            get
            {
                return GetCredencial();
            }
        }

        private new string GetCredencial()
        {
            return $"Código: {_codigo} {_apellido}, {_nombre}";
        }

        public override string ToString()
        {
            return GetCredencial();
        }
    }
}
