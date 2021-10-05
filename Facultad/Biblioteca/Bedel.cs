using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo { get => _apodo; set => _apodo = value; }

        public Bedel(string apodo, string nombre, string apellido, int legajo, DateTime fecha, DateTime ingreso) : base(legajo, ingreso, nombre, apellido, fecha)
        {
            _apodo = apodo;
        }

        public override string GetNombreCompleto()
        {
            return "Bedel " + _apodo;
        }
    }
}
