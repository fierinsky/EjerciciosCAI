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

        public string Apellido { get => _apellido; set => _apellido = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public int Edad { get => int.Parse(DateTime.Now - _fechaNacimiento); }

        public Persona(string nombre, string apellido, DateTime fecha)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fecha;
        }

        public Persona()
        {

        }

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
