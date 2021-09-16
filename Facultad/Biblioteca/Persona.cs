using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Persona
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
            set
            {
                _nombre = value;
            }
        }

        public int Edad { get => int.Parse(DateTime.Now - _fechaNacimiento); }


        public virtual string GetCredencial()
        {
            return "";
        }

        public virtual string GetNombreCompleto()
        {
            return _nombre + " " + _apellido;
        }
    }
}
