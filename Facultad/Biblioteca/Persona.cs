using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        protected string _apellido;
        protected DateTime _fechaNacimiento;
        protected string _nombre;

        public string Apellido
        {
            get
            {
                return _apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public int Edad
        {
            get
            {
                return int.Parse(DateTime.Now - _fechaNacimiento);
            }
        }

        protected string GetCredencial()
        {
            return "";
        }

        protected string GetNombreCompleto()
        {
            return _nombre + " " + _apellido;
        }
    }
}
